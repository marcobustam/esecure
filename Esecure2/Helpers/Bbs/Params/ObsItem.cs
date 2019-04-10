using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bbs.Models.Params
{
    public class ObsItem
    {
        public int ObsItemID { get; set; }

        public int ObsCategoryID { get; set; }

        [Display(Name = "#")]
        public string ObsItemUname { get; set; }


        public string ObsItemDescription { get; set; }

    }
}
