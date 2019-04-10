using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bbs.Models.Params
{
    public class WorkSite
    {
        [Display(Name = "#")]
        public int WorkSiteID { get; set; }
        [Display(Name = "Área de trabajo")]
        public string WorkSiteName { get; set; }
              

        [Display(Name="Instalación")]
        public int SiteID { get; set; }
    }
}
