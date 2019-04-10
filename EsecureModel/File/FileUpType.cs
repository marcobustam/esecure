using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EsecureModel.File
{
    public class FileUpType
    {
        [Display(Name="ID Tipo de Archivo")]
        public int FileUpTypeID { get; set; }
        [Display(Name = "Tipo de Archivo")]
        public string FileUpTypeName { get; set; }
    }
}
