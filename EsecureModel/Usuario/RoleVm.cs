using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EsecureModel.Usuario
{
    public class RoleVm
    {
        [Required]
        public string RoleID { get; set; }
        [Required]
        public string RoleName { get; set; }


        public string[] IdsToAdd { get; set; }
        public string[] IdsToRemove { get; set; }
    }
}
