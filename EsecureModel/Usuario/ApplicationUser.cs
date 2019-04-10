using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EsecureModel.Usuario
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Id")]
        public int ApplicationUserID { get; set; }
        [DisplayName("Usuario")]
        public ApplicationUser() : base() { }
        [DisplayName("Nombre")]
        public string FirstName { get; set; }
        [DisplayName("Apellido")]
        public string LastName { get; set; }
        [DisplayName("Calle")]
        public string Street { get; set; }
        [DisplayName("Ciudad")]
        public string City { get; set; }
        [DisplayName("Provincia")]
        public string Province { get; set; }
        [DisplayName("Cod. Postal")]
        public string PostalCode { get; set; }
        [DisplayName("País")]
        public string Country { get; set; }
        [DisplayName("Empresa")]
        public int EmpresaID { get; set; }

        public string GetUserFullName ()
        {
            return FirstName + " " + LastName;
        }
    }
}
