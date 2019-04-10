using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsecureModel.Exam
{
    public class Question
    {
        public int QuestionID { get; set; }
        public int TestID { get; set; }
        public int CategoryID { get; set; }
        public string QuestionTxt { get; set; }
        
    }
}
