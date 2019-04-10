using EsecureModel.Planificacion;
using EsecureModel.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EsecureModel.Faena
{
    public class Empresa
    {
        [Display(Name="Identificador Empresa")]
        public int EmpresaID { get; set; }
        [Display(Name = "Nombre Comercial")]
        public string NombreFantasia { get; set; }
        [Display(Name = "Razón Social")]
        public string RazonSocial { get; set; }
        [Display(Name = "RUT")]
        public string RutChile { get; set; }
        /// <summary>
        /// Referencia a una persona que es el representante Legal de la empresa
        /// </summary>
        [System.ComponentModel.DisplayName("Representante")]
        public int PersonaID { get; set; }
        [Display(Name = "Faenas")]
        public ICollection<Faena> Faenas { get; set; }
        [Display(Name = "Planes")]
        public ICollection<Plan> Planes { get; set; }

        [System.ComponentModel.DisplayName("Lista de usuarios")]
        public IList<ApplicationUser> ListaUsuarios { get; set; }
    }
}
