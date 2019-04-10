using System;
using System.Collections.Generic;
using System.Text;

namespace EsecureModel.Planificacion
{
    public class ListaDeTareas
    {
        public ListaDeTareas(int planID)
        {
            PlanID = planID;
            Nombre = "Lista de Tareas - Plan: " + planID;
            ListaTareas = new List<Tarea>();
        }
        public ListaDeTareas()
        {
            PlanID = 0;
            Nombre = "Lista de Tareas - Plan: " + 0;
            ListaTareas = new List<Tarea>();
        }
        [System.ComponentModel.DisplayName("# Tarea")]
        public int ListaDeTareasID { get; set; }
        [System.ComponentModel.DisplayName("# Plan")]
        public int PlanID { get; set; }
        [System.ComponentModel.DisplayName("Nombre de Tarea")]
        public string Nombre { get; set; }
        [System.ComponentModel.DisplayName("Tareas")]
        public ICollection<Tarea> ListaTareas { get; set; }

        public void AddTarea (Tarea t)
        {
            ListaTareas.Add(t);
        }

        public static implicit operator ListaDeTareas(List<ListaDeTareas> v)
        {
            throw new NotImplementedException();
        }
    }
}
