using System;
using System.Collections.Generic;
using System.Text;

namespace EsecureModel.Planificacion
{
    public class HistoricoTarea
    {
        public HistoricoTarea(Tarea estaTarea, EstadoTarea nuevoEstado )
        {
            TareaID = estaTarea.TareaID;
            EstadoAnterior = estaTarea.EstadoID;
            NuevoEstado = nuevoEstado;
            Nombre = "Anonimouse";
            TimeStamp = DateTime.Now;

        }
        /// <summary>
        /// Crear un registro de histórico de tarea.
        /// </summary>
        /// <param name="estaTarea"> La tarea que cambiará de estado. </param>
        public HistoricoTarea(Tarea estaTarea)
        {
            TareaID = estaTarea.TareaID;
            NuevoEstado = estaTarea.EstadoID;
            EstadoAnterior = 0;
            Nombre = "Anonimouse";
            TimeStamp = DateTime.Now;
        }
        public HistoricoTarea()
        {
            TareaID = 0;
            NuevoEstado = 0;
            EstadoAnterior = 0;
            Nombre = "Anonimouse";
            TimeStamp = DateTime.Now;
        }


        [System.ComponentModel.DisplayName("# Registro")]
        public int HistoricoTareaID { get; set; }
        [System.ComponentModel.DisplayName("# Tarea")]
        public int TareaID { get; set; }
        [System.ComponentModel.DisplayName("Estado")]
        public EstadoTarea EstadoAnterior { get; set; }
        [System.ComponentModel.DisplayName("Nuevo Estado")]
        public EstadoTarea NuevoEstado { get; set; }
        [System.ComponentModel.DisplayName("Fecha Registro")]
        public DateTime TimeStamp { get; set; }
        [System.ComponentModel.DisplayName("Nombre")]
        public string Nombre { get; set; }

    }
}
