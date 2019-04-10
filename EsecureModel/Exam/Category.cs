using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EsecureModel.Exam
{
    public class Category
    {
        [Display(Name="ID Categoría")]
        public int CategoryID { get; set; }
        [Display(Name = "Categoría")]
        public string Name { get; set; }
    }
}
