using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EsecureModel.File
{
    public class FileUp
    {
        [Display(Name = "Modificado")]
        public int FileUpID { get; set; }
        [Display(Name = "Nombre de Archivo")]
        public string FileName { get; set; }
        [Display(Name = "Código interno")]
        public string FileUid { get; set; }
        [Display(Name = "Directorio")]
        public int FolderUpID { get; set; }
        [ForeignKey("FileTypeID")]
        public int FileTypeID { get; set; }
        [Display(Name = "Tamaño en Bytes")]
        public int FileSize { get; set; }
        [Display(Name = "Creado")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.DateTime)]
        public DateTime TimeStamp { get; set; }
        [Display(Name = "Modificado")]
        [DataType(DataType.DateTime)]
        public DateTime LastMod { get; set; }

        [Display(Name = "Propietario")]
        public int PersonaID { get; set; }
        [Display(Name = "Enlace AWS")]
        public string AwsRoute { get; set; }

    }
}
