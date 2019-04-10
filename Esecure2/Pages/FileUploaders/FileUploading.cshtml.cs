using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
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
using EsecureWebApp.Filers;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Usuario;
using Microsoft.Extensions.Configuration;
using Esecure2.Data;

namespace EsecureWebApp.Pages.FileUploaders
{
    
    public class FileUploadingModel : BaseCodeModel
    {
        //private readonly Esecure2.Data.ApplicationDbContext _context;
        private readonly IHostingEnvironment _environment;
        private static readonly RegionEndpoint bucketRegion = RegionEndpoint.USWest2;
        private static IAmazonS3 s3Client;

        /*
        public FileUploadingModel(Esecure2.Data.ApplicationDbContext context)
        {
            _context = context;
        }*/
        public FileUploadingModel(IHostingEnvironment environment,IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
            _environment = environment;
        }
        
        public IList<FolderUp> FolderUpList { get; set; }
        [BindProperty]
        public FileUp NewFileUp { get; set; }
        public string htmlTree { get; set; }
        //public string acurm { get; set; }
        //List<int> idList = new List<int>();
        private const string bucketName = "";
        private const string keyName = "*** provide a name for the uploaded object ***";
        private const string filePath = "*** provide the full path name of the file to upload ***";
        // Specify your bucket region (an example region is shown).
        // us-east-1
        
        [BindProperty]
        public Microsoft.AspNetCore.Http.IFormFile FileUpload { get; set; }
        [Required]
        [BindProperty]
        [Display(Name = "Archivo")]
        public Microsoft.AspNetCore.Http.IFormFile Upload { get; set; }
        public async Task OnGetAsync()
        {
            FolderUpList = await _context.FolderUp.ToListAsync();
            foreach (var e in FolderUpList)
            {
                var subfolders = FolderUpList.Where(fo => fo.FolderUpParent == e.FolderUpID).ToList();
                e.FolderUpFolders = subfolders;
            }

            htmlTree = FileUpHelper.GetFolderUpTree(FolderUpList);
        }
        public async Task<IActionResult> OnPost()
        {
            var errorMsg = "";
            if (!ModelState.IsValid)
            {
                return Page();
            }
            // var helper = FileHelper.ProcessFormFile(Upload, ModelState);
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var guid = Guid.NewGuid();
            NewFileUp.FileUid = guid.ToString();
            NewFileUp.TimeStamp = DateTime.Now;
            NewFileUp.LastMod = DateTime.Now;
            _context.FileUp.Add(NewFileUp);
            await _context.SaveChangesAsync();
            //
            
            
            /******************************/
            try
            {
                //var f = new ;
                if (FileHelper.GetConfigFromDb(_context))
                {


                    //fileConfigurator
                    // var fs = f.();

                    // var file = Path.Combine(_environment.ContentRootPath, "Data", "Uploads", guid.ToString());
                    var file = Path.Combine(_environment.ContentRootPath, "Data", "Uploads", NewFileUp.FileUid);
                    using (var fileStream = new FileStream(file, FileMode.Create))
                    {
                        await Upload.CopyToAsync(fileStream);
                    }
                    var options = new CredentialProfileOptions
                    {
                        AccessKey = FileHelper.getFileConfigAccessKey(),
                        SecretKey = FileHelper.getFileConfigSecretKey()
                    };
                    var profile = new CredentialProfile("basic_profile", options);
                    profile.Region = RegionEndpoint.USWest2;
                    var netSDKFile = new NetSDKCredentialsFile();
                    netSDKFile.RegisterProfile(profile);
                    /// crear la solicitud para subir el archivo
                    /// recibe 3 parámetros: 
                    /// 1. BucketName: el nombre del bucket
                    /// 2. Key: el nombre del archivo, es como se quiere llamar, incluso con ruta relativa. Ejemplo: directorio/archivo.txt
                    /// 3. FilePath: ruta física del archivo a subir
                    PutObjectRequest request = new PutObjectRequest()
                    {
                        BucketName = FileHelper.getFileConfigBucketName(),
                        Key = NewFileUp.FileUid,
                        FilePath = file //FileHelper.getFileConfigFilePath()
                    };
                    //asadasdasdsadsa 
                    AmazonS3Client client = new AmazonS3Client(RegionEndpoint.USWest2);
                    PutObjectResponse response = await client.PutObjectAsync(request);
                }
            }
            catch (AmazonS3Exception amazonS3Exception)
            {
                if (amazonS3Exception.ErrorCode != null &&
                  (amazonS3Exception.ErrorCode.Equals("InvalidAccessKeyId")
                  ||
                  amazonS3Exception.ErrorCode.Equals("InvalidSecurity")))
                {
                    errorMsg = "Check the provided AWS Credentials.For service sign up go to http://aws.amazon.com/s3";
                }
                else if (amazonS3Exception.ErrorCode.Equals("PermanentRedirect"))
                {
                    errorMsg = amazonS3Exception.Message;
                }
                else
                {
                    errorMsg = "Error occurred. Message:" + amazonS3Exception.Message + " when writing an object";
                }
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;
            }
            finally
            {
                RedirectToPage("/Error", new { errorMsg });
            }
            /******************************/
            return RedirectToPage("/FileUploaders/Files/Index");
        }
        public void subeFile ()
        {
            //_environment = environment;
            AmazonS3Config cfg = new AmazonS3Config();
            cfg.RegionEndpoint = bucketRegion;
            var options = new CredentialProfileOptions
            {
                AccessKey = "",
                SecretKey = ""
            };
            var profile = new CredentialProfile("basic_profile", options);
            profile.Region = RegionEndpoint.USEast1;
            var netSDKFile = new NetSDKCredentialsFile();
            netSDKFile.RegisterProfile(profile);
            s3Client = new AmazonS3Client("", "", RegionEndpoint.EUWest2);
            UploadFileAsync().Wait();

        }
        private static async Task UploadFileAsync()
        {
            try
            {
                var fileTransferUtility =
                    new TransferUtility(s3Client);

                // Option 1. Upload a file. The file name is used as the object key name.
                await fileTransferUtility.UploadAsync(filePath, bucketName);
                Console.WriteLine("Upload 1 completed");

                // Option 2. Specify object key name explicitly.
                await fileTransferUtility.UploadAsync(filePath, bucketName, keyName);
                Console.WriteLine("Upload 2 completed");

                // Option 3. Upload data from a type of System.IO.Stream.
                using (var fileToUpload =
                    new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    await fileTransferUtility.UploadAsync(fileToUpload,
                                               bucketName, keyName);
                }
                Console.WriteLine("Upload 3 completed");

                // Option 4. Specify advanced settings.
                var fileTransferUtilityRequest = new TransferUtilityUploadRequest
                {
                    BucketName = bucketName,
                    FilePath = filePath,
                    StorageClass = S3StorageClass.StandardInfrequentAccess,
                    PartSize = 6291456, // 6 MB.
                    Key = keyName,
                    CannedACL = S3CannedACL.PublicRead
                };
                fileTransferUtilityRequest.Metadata.Add("param1", "Value1");
                fileTransferUtilityRequest.Metadata.Add("param2", "Value2");

                await fileTransferUtility.UploadAsync(fileTransferUtilityRequest);
                Console.WriteLine("Upload 4 completed");
            }
            catch (AmazonS3Exception e)
            {
                Console.WriteLine("Error encountered on server. Message:'{0}' when writing an object", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unknown encountered on server. Message:'{0}' when writing an object", e.Message);
            }
        }
        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }
        //    var guid = Guid.NewGuid();
        //    var fileName = guid.ToString();
        //    // FileUpload = guid.ToString();
        //    var filePath = Path.Combine(_environment.ContentRootPath, "wwwroot", "fileUp", fileName);
        //    using (var fileStream = new FileStream(filePath, FileMode.Create))
        //    {
        //        await FileUpload.CopyToAsync(fileStream);
        //    }
        //    // recoger el archivo y mandarlo a S3.

        //    // await UploadFileBucketAsync("", "elasticbeanstalk-us-east-1-064043355589");
        //    await UploadFileBucketAsync(filePath, bucketName);
        //    return Page();
        //}
        private static async Task UploadFileBucketAsync(string filePath, string bucketName)
        {
            try
            {
                var fileTransferUtility =
                    new TransferUtility(s3Client);

                // Option 1. Upload a file. The file name is used as the object key name.
                await fileTransferUtility.UploadAsync(filePath, bucketName);
            }
            catch (AmazonS3Exception e)
            {
                Console.WriteLine("Error encountered on server. Message:'{0}' when writing an object", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unknown encountered on server. Message:'{0}' when writing an object", e.Message);
            }
        }
        //private static async Task UploadFileAsyncS3()
        //{
        //    try
        //    {
        //        var fileTransferUtility =
        //            new TransferUtility(s3Client);

        //        // Option 1. Upload a file. The file name is used as the object key name.
        //        await fileTransferUtility.UploadAsync(filePath, bucketName);
        //        Console.WriteLine("Upload 1 completed");

        //        // Option 2. Specify object key name explicitly.
        //        await fileTransferUtility.UploadAsync(filePath, bucketName, keyName);
        //        Console.WriteLine("Upload 2 completed");

        //        // Option 3. Upload data from a type of System.IO.Stream.
        //        using (var fileToUpload =
        //            new FileStream(filePath, FileMode.Open, FileAccess.Read))
        //        {
        //            await fileTransferUtility.UploadAsync(fileToUpload,
        //                                       bucketName, keyName);
        //        }
        //        Console.WriteLine("Upload 3 completed");

        //        // Option 4. Specify advanced settings.
        //        var fileTransferUtilityRequest = new TransferUtilityUploadRequest
        //        {
        //            BucketName = bucketName,
        //            FilePath = filePath,
        //            StorageClass = S3StorageClass.StandardInfrequentAccess,
        //            PartSize = 6291456, // 6 MB.
        //            Key = keyName,
        //            CannedACL = S3CannedACL.PublicRead
        //        };
        //        fileTransferUtilityRequest.Metadata.Add("param1", "Value1");
        //        fileTransferUtilityRequest.Metadata.Add("param2", "Value2");

        //        await fileTransferUtility.UploadAsync(fileTransferUtilityRequest);
        //        Console.WriteLine("Upload 4 completed");
        //    }
        //    catch (AmazonS3Exception e)
        //    {
        //        Console.WriteLine("Error encountered on server. Message:'{0}' when writing an object", e.Message);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Unknown encountered on server. Message:'{0}' when writing an object", e.Message);
        //    }

        //}
    }
}