using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EsecureModel.Usuario
{
    public class ApplicationRole : IdentityRole
    {

        public ApplicationRole() : base() { }

        public ApplicationRole(string roleName) : base(roleName) { }

        public ApplicationRole(string roleName, string description,
            DateTime createdDate)
            : base(roleName)
        {
            base.Name = roleName;

            this.Description = description;
            this.CreatedDate = createdDate;
        }

        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Id")]
        public int IdentityRoleID { get; set; }
        [Display(Name = "Nombre")]
        public string IdentityRoleName { get; set; }
        [Display(Name = "Descripción")]
        public string IdentityRoleDescriptor { get; set; }
    }
}
