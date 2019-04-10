using EsecureModel.Faena;
using System;
using System.Collections.Generic;
using System.Text;
using EsecureModel.Personal;
using EsecureModel.Issues;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EsecureModel.Planificacion
{
    public class Plan
    {
        [DisplayName("# Plan")]
        public int PlanID { get; set; }
        [DisplayName("Nombre Plan")]
        public string NombrePlan { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        /// <summary>
        /// Referencia al responsable
        /// </summary>
        [DisplayName("Responsable")]
        public int PersonaID { get; set; }
        [DisplayName("Persona Responsable")]
        public Persona Persona { get; set; }
        /// <summary>
        /// Referencia a la empresa a la pertenece el plan
        /// </summary>
        [DisplayName("Empresa")]
        public int EmpresaID { get; set; }
        public Empresa Empresa { get; set; }
        [DisplayName("Issues")]
        public IssueList ListaDeIssues { get; set; }
        [DisplayName("Tareas")]
        public ListaDeTareas ListaTareas { get; set; }
        [DisplayName("F. Creación")]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{dd/0:MM/yyyy}")]
        // [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        // [DataType(DataType.Date)]
        // [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime TimeStamp { get; set; }
        [DisplayName("Últ. Modificación")]
        public DateTime Umod { set; get; }

        public string GetUmod()
        {/*
            if((DateTime.Now - Umod).TotalDays>1)
            {*/
                return Umod.ToString("dd-MM-yyyy}");
            /*
            }
            else
            {
                return Umod.ToString("{0:dd/0:MM/yyyy HH:mm:ss}");
            }
            */
        }

        // public int UsuarioUmod { get; set; }
        public Plan()
        {
            PlanID = 0;
            NombrePlan = "Nuevo Plan";
            PersonaID = 0;
            EmpresaID = 0;
            
            ListaTareas = new ListaDeTareas
            {
                ListaDeTareasID = 0,
                Nombre = "Tareas para: " + NombrePlan,
                ListaTareas = new List<Tarea>() { }
            };
            
            TimeStamp = DateTime.Now;
            Umod = DateTime.Now;
        }
    }
}
