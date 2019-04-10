using EsecureModel.Personal;
using EsecureModel.Planificacion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EsecureModel.Exam
{
    /// <summary>
    /// Corresponde a un evento de verificación.
    /// </summary>
    public class Examination
    {
        [Display(Name = "ID Examen")]
        public int ExaminationID { get; set; }
        [Display(Name = "Timestamp")]
        public DateTime TimeStamp { get; set; }
        [Display(Name = "Examinador")]
        public int PersonaID1 { get; set; }
        [Display(Name = "Resp. Faena")]
        public int PersonaID2 { get; set; }
        [Display(Name = "Lista Verificación")]
        public Test Prueba { get; set; }
        [Display(Name = "Id. LV")]
        public int? TestID { get; set; }
        [Display(Name = "ID Empresa")]
        // TODO: relacionar con Empresa y Faena
        public int EmpresaID { get; set; }
        [Display(Name = "ID Faena")]
        public int FaenaID { get; set; }
        [Display(Name = "ID Tarea")]
        public int TareaID { get; set; }

        public int PlanID { get; set; }
        [Display(Name = "Preguntas")]
        public int TotalRespuestas { get; set; }
        [Display(Name = "Contestadas")]
        public int RespuestasCompletadas { get; set; }
        [Display(Name = "Lista Respuestas")]
        public ICollection<Response> ListaRespuestas { get; set; }

        public static List<string> GetCategoryStatus(IList<Question> Qlist, ICollection<Response> ListaRespuestas)
        {
            List<string> categorias = new List<string>();

            foreach(var question in Qlist)
            {
                Response resp = ListaRespuestas.Where(re => re.QuestionID == question.QuestionID).First();
                if(resp != null)
                {
                    categorias.Add("Cat:" + question.CategoryID + " - Resp:" + resp.ResponseTypeID );
                }
                
            }
            return categorias;
        }

        public void AddResponse( Response r)
        {
            if(ListaRespuestas!= null)
            {
                ListaRespuestas.Add(r);
            }
            else
            {
                ListaRespuestas = new List<Response>
                {
                    r
                };
            }
            
        }

        public int CountRespType(int respType)
        {
            if(ListaRespuestas==null)
            {
                return ListaRespuestas.Where(r => r.ResponseTypeID == respType).Count();
            }
            else
            {
                return 0;
            }
        }
        public Examination()
        {

        }
        public Examination(Tarea tarea)
        {
            // Defaults OK
            TimeStamp = DateTime.Now;
            TotalRespuestas = 0;
            RespuestasCompletadas = 0;
            ListaRespuestas = new List<Response>();

            // tarea
            TareaID = tarea.TareaID;
            //TestID = tarea.Checklist.TestID;
            TestID = tarea.TestID;
            PlanID = tarea.PlanID;
            // TODO: Requeridos -> Completar!
            Prueba = null;
            EmpresaID = tarea.EmpresaID;
            FaenaID = tarea.FaenaID;
            // tarea.PlanID;
            // tarea.TareaID
            // tarea.FechaEjecucionReal;
            PersonaID1 = 0;
            PersonaID2 = 0;
        }

    }
}
