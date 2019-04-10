using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EsecureModel.Bbs.Bussiness
{
    public class Inspection
    {
        public int InspectionID { get; set; }
        [Display(Name = "Fecha de Observación")]
        //[DisplayFormat(DataFormatString = "{yyyy-mm-dd}")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy} HH:mm")]
        public DateTime InspectionDate { get; set; }
        public int MyProperty { get; set; }

        [Display(Name = "Persona Observada")]
        public int PersonID1 { get; set; }
        [Display(Name = "Observador")]
        public int PersonID2 { get; set; }
        [Display(Name = "Gerente")]
        public int PersonID3 { get; set; }
        [Display(Name = "Gerencia")]
        public int DivisionID { get; set; }
        [Display(Name = "Instalación")]
        public int SiteID { get; set; }
        [Display(Name = "Área")]
        public int WorkSiteID { get; set; }

        [Display(Name = "Categoría")]
        public int ObsCategoryID { get; set; }
        [Display(Name = "Item")]
        public int ObsItemID { get; set; }

        [Display(Name = "Acción Segura")]
        public bool IsSafeAction { get; set; }
        [Display(Name = "Fecha de sistema")]
        public DateTime Timestamp { get; set; }

    }
}
