using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using Esecure2.Data;
using EsecureModel.Config;
using EsecureModel.Mailer;

using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Threading.Tasks;
using EsecureModel.File;
using EsecureWebApp.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.Runtime.CredentialManagement;
using Amazon;
using Amazon.S3.Transfer;
using EsecureModel.Filer;

namespace EsecureWebApp.Filers
{
    
    public class FileHelper
    {
        private static FileConfigurator fileConfigurator { get; set; }
        private readonly Esecure2.Data.ApplicationDbContext _context;
        private readonly IHostingEnvironment _environment;
        private static readonly RegionEndpoint bucketRegion; // = RegionEndpoint.USEast1
        private static IAmazonS3 s3Client;

        public FileHelper(ApplicationDbContext context)
        {
            // _configuration = configuration;
            _context = context;
            fileConfigurator = new FileConfigurator();
        }
        /******************************************************/
        private static List<int> idList = new List<int>();
        private static string htmlTree { get; set; }

        public static string GetFolderUpTree(IList<FolderUp> folderList)
        {
            idList = new List<int>();
            return Despliega(folderList);

        }
        private static string Despliega(IList<FolderUp> folderList)
        {
            if (folderList.Any())
            {
                var html = "";
                foreach (var item in folderList.OrderBy(fo => fo.FolderUpParent))

                    // si no lo hemos desplegado en un nivel superior
                    if (!idList.Exists(it => it == item.FolderUpID))
                    {
                        idList.Add(item.FolderUpID);
                        // item unico (hoja)
                        if (!item.FolderUpFolders.Any())
                        {
                            html = html + "<li id='" + item.FolderUpID + "'>";
                            //html = html + "<button id='"+ item.FolderUpID + "' class='alert-link' onclick='putPath(this)'>" + item.FolderUpID + "-" + item.FolderUpName + "</ button >";
                            // good!!--> 
                            // html = html + "<button type='button'  id='" + item.FolderUpID + "' onclick='putPath(this)'>" + item.FolderUpID + "-" + item.FolderUpName + "</button >";
                            html = html + item.FolderUpID + "-" + item.FolderUpName;
                            // <button type="button" class="btn btn-primary" data-toggle="button" aria-pressed="false" autocomplete="off">
                            html = html + "</li>";
                        }
                        // tiene mas elementos (nodo)
                        else
                        {
                            // agregamos la etiqueta <li> y el boton
                            html = html + "<li id='" + item.FolderUpID + "'>";
                            // good --> 
                            // html = html + "<button type='button'  id='" + item.FolderUpID + "' onclick='putPath(this)'>" + item.FolderUpID + "-" + item.FolderUpName + "</button>";
                            html = html + item.FolderUpID + "-" + item.FolderUpName;
                            // recurse
                            var retorno = Despliega(item.FolderUpFolders);
                            if (retorno != "")
                            {
                                html = html + "<ul>";
                                html = html + retorno;
                                html = html + "</ul>";
                            }
                            html = html + "</li>";
                        }
                        htmlTree = htmlTree + html;
                    }
                return html;
            }
            return "";
        }

        string Despliega2(IList<FolderUp> folderList, int root)
        {
            var html = "<li id='0'>No hay elementos que mostrar</li>";
            if (!folderList.Any())
            {
                return html;
            }
            html = "";
            foreach (var item in folderList.OrderBy(fo => fo.FolderUpParent))
            {
                // si no lo hemos desplegado en un nivel superior
                if (!idList.Exists(it => it == item.FolderUpID))
                {
                    idList.Add(item.FolderUpID);
                    root++;
                    html = html + "<li id='" + item.FolderUpID + "'>";
                    // valor desplegado
                    html = html + root + "-" + item.FolderUpName;

                    // item unico (hoja)
                    if (item.FolderUpFolders.Any())
                    {
                        // recurse
                        var retorno = Despliega2(item.FolderUpFolders, 0);
                        // si hay algo que desplegar
                        if (retorno != "")
                        {
                            html = html + "<ul>";
                            html = html + retorno;
                            html = html + "</ul>";
                        }

                    }
                    html = html + "</li>";
                    htmlTree = htmlTree + html;
                }
            }
            return html;

        }
        /******************************************************/    
        public static string getFileConfigBucketName()
        {
            return fileConfigurator.FileConfigBucketName;
        }
        public static string getFileConfigKeyName()
        {
            return fileConfigurator.FileConfigKeyName;
        }
        public static string getFileConfigFilePath()
        {
            return fileConfigurator.FileConfigFilePath;
        }
        public static string getFileConfigAccessKey()
        {
            return fileConfigurator.FileConfigAccessKey;
        }
        public static string getFileConfigSecretKey()
        {
            return fileConfigurator.FileConfigSecretKey;
        }
        public static string getFileConfigLocalPath()
        {
            return fileConfigurator.FileConfigLocalPath;
        }
        public static string getFileConfigBucketZone()
        {
            return fileConfigurator.FileConfigBucketZone;
        }

        public static bool GetConfigFromDb(ApplicationDbContext context)
        {
            List<WebConfiguration> config = context.WebConfiguration.Where(co => co.WebConfigurationGroup == "AwsS3Bucket").ToList();
            if (config.Count == 0)
            {
                return false;
            }
            if (fileConfigurator == null)
            {
                fileConfigurator = new FileConfigurator();
                fileConfigurator.FileConfigBucketName = config.Where(co => co.WebConfigurationName == "BucketName").FirstOrDefault().WebConfigurationValue.ToString();
                fileConfigurator.FileConfigKeyName = config.Where(co => co.WebConfigurationName == "AwsS3UserName").FirstOrDefault().WebConfigurationValue.ToString();
                fileConfigurator.FileConfigFilePath = config.Where(co => co.WebConfigurationName == "Documental").FirstOrDefault().WebConfigurationValue.ToString();
                fileConfigurator.FileConfigAccessKey = config.Where(co => co.WebConfigurationName == "IdClaveAcceso").FirstOrDefault().WebConfigurationValue.ToString();
                fileConfigurator.FileConfigSecretKey = config.Where(co => co.WebConfigurationName == "ClaveAcceso").FirstOrDefault().WebConfigurationValue.ToString();
                fileConfigurator.FileConfigLocalPath = config.Where(co => co.WebConfigurationName == "LocalPath").FirstOrDefault().WebConfigurationValue.ToString();
                //fileConfigurator.FileConfigBucketZone = config.Where(co => co.WebConfigurationName == "BucketZone").FirstOrDefault().WebConfigurationValue.ToString();
            }
            else
            {
                fileConfigurator.FileConfigBucketName = config.Where(co => co.WebConfigurationName == "BucketName").FirstOrDefault().WebConfigurationValue.ToString();
                fileConfigurator.FileConfigKeyName = config.Where(co => co.WebConfigurationName == "AwsS3UserName").FirstOrDefault().WebConfigurationValue.ToString();
                fileConfigurator.FileConfigFilePath = config.Where(co => co.WebConfigurationName == "Documental").FirstOrDefault().WebConfigurationValue.ToString();
                fileConfigurator.FileConfigAccessKey = config.Where(co => co.WebConfigurationName == "IdClaveAcceso").FirstOrDefault().WebConfigurationValue.ToString();
                fileConfigurator.FileConfigSecretKey = config.Where(co => co.WebConfigurationName == "ClaveAcceso").FirstOrDefault().WebConfigurationValue.ToString();
                fileConfigurator.FileConfigLocalPath = config.Where(co => co.WebConfigurationName == "LocalPath").FirstOrDefault().WebConfigurationValue.ToString();
                //fileConfigurator.FileConfigBucketZone = config.Where(co => co.WebConfigurationName == "BucketZone").FirstOrDefault().WebConfigurationValue.ToString();
            }
            if (!fileConfigurator.CheckValues())
            {
                return false;
            }
            return true;
        }
       
    }
}
