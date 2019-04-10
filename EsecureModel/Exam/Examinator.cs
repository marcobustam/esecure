using EsecureModel.Personal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsecureModel.Exam
{
    /// <summary>
    /// Es la persona que realiza la evaluación, puede o no, ser un prevencionista, pero debe estar habilitado para realizar este tipo de labores.
    /// En el caso de una auto-evaluación el objeto de la clase relacionada Examinee apuntaría la misma persona.
    /// </summary>
    public class Examinator : Persona
    {

        public int ExamineeID { get; set; }
        public string Name { get; set; }

    }
}
