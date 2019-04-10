using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EsecureModel.File
{
    public class FolderUp
    {
        [Display(Name = "Identificador")]
        public int FolderUpID { get; set; }
        [Display(Name = "Empresa")]
        [ForeignKey("EmpresaID")]
        public int EmpresaID { get; set; }
        [StringLength(100, ErrorMessage = "Nombre de directorio supera los 100 carcteres.")]
        [Display(Name = "Nombre de Directorio")]
        public string FolderUpName { get; set; }

        [Display(Name = "Directorios")]
        public IList<FolderUp> FolderUpFolders { get; set; }
        [Display(Name = "Archivos")]
        public IList<FileUp> FolderUpFiles { get; set; }
        [ForeignKey("FolderUpID")]
        [Display(Name = "Directorio superior")]
        public int FolderUpParent { get; set; }
        [Display(Name = "Creado")]
        [DataType(DataType.DateTime)]

        // TODO: @Html.TextBoxFor(m => m.StartDate, "{0:MM/dd/yyyy}", new { @class = "form-control default-date-picker" }) 
        //  [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
        public DateTime TimeStamp { get; set; }
        [Display(Name = "Modificado")]
        [DataType(DataType.DateTime)]
        public DateTime LastMod { get; set; }
        public FolderUp()
        {
            FolderUpFolders = new List<FolderUp>() { };
            FolderUpFiles = new List<FileUp>() { };
            TimeStamp = DateTime.Now;
        }
    }
}
