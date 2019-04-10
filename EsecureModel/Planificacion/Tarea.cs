using EsecureModel.Exam;
using EsecureModel.Verificaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EsecureModel.Planificacion
{
    public enum EstadoTarea
    {
        Nueva, Planificada, Iniciada, Pendiente, Realizada, Cancelada, Suspendida
    };
    // TODO: Agregar fecha de creación con TimeStamp
    public class Tarea
    {
        [System.ComponentModel.DisplayName("# Tarea")]
        public int TareaID { get; set; }
        /// <summary>
        /// Referencia al plan al cual pertenece la tarea
        /// </summary>
        [System.ComponentModel.DisplayName("# Plan")]
        public int PlanID { get; set; }

        /// <summary>
        /// Empresa dueña de la tarea
        /// </summary>
        [Display(Name="Empresa")]
        public int EmpresaID { get; set; }

        [System.ComponentModel.DisplayName("Nombre Tarea")]
        public string NombreTarea { get; set; }

        [Display(Name = "Faena / Sucursal")]
        public int FaenaID { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        [System.ComponentModel.DisplayName("Fec. Ini. Planificada")]
        public DateTime FechaPlanificada { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        [System.ComponentModel.DisplayName("Fec. Fin Planificada")]
        public DateTime FechaFinPlanificada { get; set; }
        /*
        [System.ComponentModel.DisplayName("# Actividad")]
        public int ActividadVerificacionID { get; set; }

        [System.ComponentModel.DisplayName("Actividad")]
        public ActividadVerificacion Actividad { get; set; }
        */
        /*
        [System.ComponentModel.DisplayName("Check List")]
        public Test Checklist { get; set; }
        */
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        [System.ComponentModel.DisplayName("Fecha Ini. Real")]
        public DateTime? FechaEjecucionReal { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        [System.ComponentModel.DisplayName("Últ. Modificación")]
        public DateTime? FechaUltimaModificacion { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        [System.ComponentModel.DisplayName("Fecha Fin Real")]
        public DateTime? FechaFinEjecucionReal { get; set; }

        /// <summary>
        /// Estado de la tarea { 0 = Creada; 1 = en Espera de la fecha de ejecucion
        /// </summary>
        [System.ComponentModel.DisplayName("Estado")]
        public EstadoTarea EstadoID { get; set; }

        public int TestID { get; set; }

        // public Tarea() { }
        public Tarea()
        {
            // TareaID = 0;
            // PlanID = 0;
            NombreTarea = "";
            // ActividadVerificacionID = 0;
            // Actividad = new ActividadVerificacion();
            EstadoID = 0;
        }

    }
}
