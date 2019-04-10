using System;
using System.Collections.Generic;
using System.Text;

namespace EsecureModel.Lexis
{
    public class Lex
    {
        public int LexID { get; set; }
        public string LexName { get; set; }
        public IList<LexTitulo> Titulos { get; set; }
    }

    public class LexTitulo
    {
        public int LexTituloID { get; set; }
        public int LexID { get; set; }
        public string LexTituloText { get; set; }
        public IList<LexParrafo> Parrafos { get; set; }
    }
    public class LexParrafo
    {
        public int LexParrafoID { get; set; }
        public int LexTituloID { get; set; }
        public int LexID { get; set; }
        public string LexParrafoText { get; set; }
        public IList<LexArt> Articulos { get; set; }
    }
    public class LexArt
    {
        public int LexArtID { get; set; }
        public int LexParrafoID { get; set; }
        public int LexTituloID { get; set; }
        public int LexID { get; set; }
        public string LexArtText { get; set; }
    }
}
