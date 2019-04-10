using System;
using System.Collections.Generic;
using System.Text;

namespace EsecureModel.Verificaciones
{
    public class ItemVerificacion
    {
        public int ItemVerificacionID { get; set; }
        public string Glosa { get; set; }
        public Dimension Dimension { get; set; }

        public int ActividadVerificacionID { get; set; }

    }
}
