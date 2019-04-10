using System;
using System.Collections.Generic;
using System.Text;

namespace EsecureModel.Verificaciones
{
    public class ActividadVerificacion
    {
        public int ActividadVerificacionID { get; set; }
        public int EmpresaID { get; set; }
        public string Descripcion { get; set; }
        public ICollection<ItemVerificacion> ListaVerificacion { get; set; }
    }
}
