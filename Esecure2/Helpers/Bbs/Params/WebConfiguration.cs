﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bbs.Models.Params
{
    public class WebConfiguration
    {
        public int WebConfigurationID { get; set; }
        [Display(Name = "Índice")]
        public int WebConfigurationIndex { get; set; }
        [Display(Name = "Grupo")]
        public String WebConfigurationGroup { get; set; }
        [Display(Name = "Nombre")]
        public String WebConfigurationName { get; set; }
        [Display(Name = "Valor")]
        public String WebConfigurationValue { get; set; }

    }
}