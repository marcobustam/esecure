using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsecureModel.Exam
{
    public class Test
    {
        public int TestID { get; set; }
        public string Name { get; set; }
        public ICollection<Question> QuestionList { get; set; }
        public Test()
        {
            TestID = 0;
            Name = "Hola hola";
            // questionList = "LOLOL";
        }
        public override string ToString()
        {
            return TestID + " - " + Name;
        }
    }
}
