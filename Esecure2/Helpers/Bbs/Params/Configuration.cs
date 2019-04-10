using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bbs.Models.Params
{
    public class Configuration
    {
        public int ConfigurationID { get; set; }
        [Display(Name = "Índice")]
        public int ConfigurationIndex { get; set; }
        [Display(Name = "Grupo")]
        public String ConfigurationGroup { get; set; }
        [Display(Name = "Nombre")]
        public String ConfigurationName { get; set; }
        [Display(Name = "Valor")]
        public String ConfigurationValue { get; set; }

    }
}
