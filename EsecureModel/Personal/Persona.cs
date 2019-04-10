using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EsecureModel.Personal
{
    public enum TipoDocumento { Rut, Pasaporte}
    public class Persona
    {
        public int PersonaID { get; set; }
        /// <summary>
        /// Documento es el RUT
        /// </summary>
        // TODO: Agregar como KEY
        [DisplayName("Documento")]
       // [StringLengthRange(Minimum = 10, ErrorMessage = "Debe tener> 10 caracteres.")]
        public string Documento { get; set; }
        [DisplayName("Tipo de Documento")]
        public TipoDocumento TipoDocumento { get; set; }
        [DisplayName("Rut Chile")]
        public string RutChile;
        public string getRutChile()
        {
            return Utiles.formatearRut(RutChile);
        }
        public void setRutChile(string value)
        {
            if (Utiles.validarRut(value))
            {
                RutChile = value;
            }
        } 
        /// <summary>
        // TODO: Agregar validación de rut.
        /// </summary>
        public string Alias { get; set; }
        [DisplayName("Nombre")]
        public string PrimerNombre { get; set; }
        [DisplayName("Segundo Nombre")]
        public string SegundoNombre { get; set; }
        [DisplayName("Apellido Paterno")]
        public string ApellidoPaterno { get; set; }
        [DisplayName("Apellido Materno")]
        public string ApellidoMaterno { get; set; }
        [Display(Name = "Empresa")]
        public int EmpresaID { get; set; }
        // public Direccion DireccionParticular { get; set; }
        // TODO: Formatear fecha para Ingreso sólo fecha sin hora
        [DisplayName("Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        public string FullName()
        {
            return PrimerNombre + " " + SegundoNombre + " " + ApellidoPaterno + " " + ApellidoMaterno;
        }
    }
}
