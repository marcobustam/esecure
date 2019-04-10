using System;
using System.Collections.Generic;
using System.Text;

namespace EsecureModel.Exam
{
    public class Obs
    {
        public int ObsID { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public List<string> ImagesList { get; set; }
    }
}
