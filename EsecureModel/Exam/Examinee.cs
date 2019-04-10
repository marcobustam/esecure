using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsecureModel.Exam
{
    /// <summary>
    /// Corresponde a la persona que será evaluada, jefe de piso, superintendente, jefe de planta, Líder de equipo, etc...
    /// </summary>
    public class Examinee
    {
        public int ExamineeID { get; set; }
        public string Name { get; set; }
    }
}
