using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using EsecureModel.Personal;
using Microsoft.AspNetCore.Identity;

namespace EsecureModel.Usuario
{
    public class LocalUser : IdentityUser
    {
        [DisplayName("Identificador")]
        public int LocalUserID { get; set; }
        [DisplayName("Identificador Persona")]
        public Persona PersonaID { get; set; }
        [DisplayName("Identidad")]
        public string IdentityID { get; set; }
        [DisplayName("Empresa")]
        public int EmpresaID { get; set; }
    }
}
