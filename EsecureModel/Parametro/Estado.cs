using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EsecureModel.Parametro
{
    public class Estado
    {
        public int EstadoID { get; set; }
        [DisplayName("Descripción")]
        public string DescripcionEstado { get; set; }
    }
}
