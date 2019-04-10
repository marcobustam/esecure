using System;
using System.Collections.Generic;
using System.Text;

namespace EsecureModel.Verificaciones
{
    public enum Resultado
    {
        Cumple, No_Cumple, No_Aplica
    }
    class Respuesta
    {
        public int RespuestaID { get; set; }
        public Resultado Resultado { get; set; }
        public string Comentario { get; set; }
        public int lala { get; set; }
    }
}
