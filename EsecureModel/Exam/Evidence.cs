using EsecureModel.File;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EsecureModel.Exam
{
    public class EvidenceType
    {
        public int EvidenceTypeID { get; set; }
        public string EvidenceTypeName { get; set; }
    }
    public class Evidence
    {
        [Display(Name = "ID Evidencia")]
        public int EvidenceID { get; set; }
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        [Display(Name = "Tipo")]
        public EvidenceType EvidenceType { get; set; }
        [Display(Name = "Archivo")]
        public FileUp FileUp { get; set; }
        public int FileUpID { get; set; }
        [Display(Name = "Creado")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.DateTime)]
        public DateTime TimeStamp { get; set; }
        [Display(Name = "Modificado")]
        [DataType(DataType.DateTime)]
        public DateTime LastMod { get; set; }
        [Display(Name = "Propietario")]
        public int PersonaID { get; set; }

        public int ResponseID { get; set; }
        // public int 
    }
}
