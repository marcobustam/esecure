using System;
using System.Collections.Generic;
using System.Text;

namespace EsecureModel.Reporte
{
    /// <summary>
    /// Estructura de informe:
    /// Informe
    /// -Portada
    /// -Encabezado
    /// -Capitulo
    /// --Titulo
    /// ---Contenido
    /// ----Imagen
    /// ----Tabla
    /// ----Grafico
    /// -Conclusiones
    /// -Anexos
    /// --Imagenes
    /// --Tablas
    /// </summary>
    public class Informe
    {
        public int InformeID { get; set; }
        public Encabezado InfEncabezado { get; set; }
        public IList<Capitulo> Capitulos { get; set; }
        public Conclusion InfConclusion { get; set; }
        public Informe ()
        {
            InformeID = 1;
            InfEncabezado = new Encabezado();
            Capitulos = new List<Capitulo>();
            Capitulos.Add(new Capitulo());
            Capitulos.Add(new Capitulo());
            InfConclusion = new Conclusion();
        }
        public override string ToString()
        {
            // var htmlReturn = "<html>";
            var htmlReturn = "";
            // htmlReturn = htmlReturn + "<head>" + InfEncabezado.ToString() + "</head><body>";
            htmlReturn = htmlReturn + "<h1>" + InfEncabezado.ToString() + "</h1>";
            if (Capitulos.Count > 0)
            {
                htmlReturn = htmlReturn + "<ol>";
                foreach (var cap in Capitulos)
                {

                    htmlReturn = htmlReturn + "<li>" +cap.ToString() + "<li>";
                }
                htmlReturn = htmlReturn + "</ol>";
            }

            htmlReturn = htmlReturn + InfConclusion.ToString();
            htmlReturn = htmlReturn + "</body>";
            htmlReturn = htmlReturn + "</html>";
            return htmlReturn;
        }
    }
    public class Encabezado
    {
        public int EncabezadoID { get; set; }
        public string Empresa { get; set; }
        public Encabezado()
        {
            EncabezadoID = 1;
            Empresa = "Bureau Veritas";
        }
        public override string ToString()
        {
            // return "<title>Informe " + EncabezadoID + ".-" + Empresa + "</title>";
            return "Informe " + EncabezadoID + ".-" + Empresa + "";
        }
    }
    public class Conclusion
    {
        public int ConclusionID { get; set; }
        public string ConclusionText { get; set; }
        public Conclusion()
        {
            ConclusionID = 1;
            ConclusionText = "Esta es una conclusión";
        }
        public override string ToString()
        {
            return "<strong>Conclusiones</strong><p>"+ ConclusionText +"</p>";
        }
    }
    /// <summary>
    /// H2
    /// </summary>
    public class Capitulo
    {
        public int CapituloID { get; set; }
        public int Orden { get; set; }
        public string Nombre { get; set; }
        public IList<Titulo> ListaTitulos { get; set; }
        public Capitulo()
        {
            CapituloID = 1;
            Orden = 1;
            Nombre = "Este es un capítulo";
            ListaTitulos = new List<Titulo>();
            ListaTitulos.Add(new Titulo());
            ListaTitulos.Add(new Titulo());
        }
        public override string ToString()
        {
            var html = "<h2>" + CapituloID + Nombre + "</h2>";
            if(ListaTitulos.Count>0)
            {
                html = html + "<ol>";
                foreach (var tit in ListaTitulos)
                {
                    html = html + "<li>" + tit.ToString() + "</li>";
                }
                html = html + "</ol>";
            }
            return html;
        }
    }
    /// <summary>
    /// H3
    /// </summary>
    public class Titulo
    {
        public int TituloID { get; set; }
        public int Orden { get; set; }
        public string NombreTitulo { get; set; }

        // TODO: Modificar
        public string Contenido { get; set; }
        public Titulo()
        {
            TituloID = 1;
            Orden = 1;
            NombreTitulo = "Este es un título";
            Contenido = "Este es el contenido del titulo";
        }
        public override string ToString()
        {
            return "<h3>" + TituloID + ".-" + NombreTitulo + "</h3><p>" + Contenido + "</p>";
        }
    }
    public class Seccion
    {
        public int SeccionID { get; set; }
        public int Orden { get; set; }
        public string NombreSeccion { get; set; }
        public IList<Contenido> ListaContenido { get; set; }
    }
    public class Contenido
    {
        public int ContenidoID { get; set; }
        public string HtmlContent { get; set; }
    }
    public class Portada
    {
        public int PortadaID { get; set; }
        public string TituloPortada { get; set; }
    }
    public class Indice
    {
        public int IndiceID { get; set; }
    }
    public class Tabla
    {
        public int TablaID { get; set; }
        public string JsonValoresTabla { get; set; }
    }
    public class Grafico
    {
        public int GraficoID { get; set; }
    }
    public class Imagen
    {
        public int ImagenID { get; set; }
    }
    public class Anexo
    {
        public int AnexoID { get; set; }
        public string TituloAnexo { get; set; }
    }

}

