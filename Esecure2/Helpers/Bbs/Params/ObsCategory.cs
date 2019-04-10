using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bbs.Models.Params
{
    public class ObsCategory
    {
        public int ObsCategoryID { get; set; }
        [Display(Name = "#")]
        public string ObsCategoryUname { get; set; }
        [Display(Name="Descripción")]
        public string ObsCategoryDescription { get; set; }
        public IList<ObsItem> ItemList { get; set; }
    }
}
