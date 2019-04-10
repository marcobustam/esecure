using EsecureModel.File;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsecureWebApp.Helpers
{
    public class FileUpHelper
    {
        private static List<int> idList = new List<int>();
        private static string htmlTree { get; set; }

        public static string GetFolderUpTree (IList<FolderUp> folderList)
        {
            idList = new List<int>();
            return Despliega(folderList);

        }
        /// <summary>
        /// Entrega un listado UL / LI con una estructura de directorios padre / hijo
        /// </summary>
        /// <param name="folderList"></param>
        /// <returns></returns>
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
    }
}
