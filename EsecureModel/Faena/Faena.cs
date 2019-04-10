using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using EsecureModel.Location;

namespace EsecureModel.Faena
{
    public class Faena
    {
        public int FaenaID { get; set; }
        [Required]

        public int EmpresaID { get; set; }
        [Display(Name = "Nombre Faena")]
        [StringLength(80)]
        [Required]
        public string NombreFaena { get; set; }
        public Direccion Ubicacion { get; set; }
        [Display(Name="Fecha Creación")]
        public DateTime Timestamp { get; set; }
        [Display(Name="Fecha Modificación")]
        public DateTime Umod { get; set; }
    }
}
