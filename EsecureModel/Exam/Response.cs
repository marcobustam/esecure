using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EsecureModel.Exam
{
    public class Response
    {
        public int ResponseID { get; set; }
        public int ExaminationID { get; set; }
        public int TestID { get; set; }
        public int QuestionID { get; set; }
        [Display(Name = "Respuesta")]
        public int ResponseTypeID { get; set; }
        public DateTime TimeStamp { get; set; }
        public IList<Evidence> EvidenceList { get; set; }
    }
}
