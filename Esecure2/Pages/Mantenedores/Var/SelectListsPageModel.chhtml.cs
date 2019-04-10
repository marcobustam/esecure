using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EsecureWebApp.Pages.Mantenedores.Var
{
    public class SelectListsPageModel : PageModel
    {
        // TODOS LOS SELECT LIST
        public SelectList PersonasNameSL { get; set; }
        public SelectList EmpresasNameSL { get; set; }
        public SelectList ActividadVerificacionNameSL { get; set; }
        public SelectList CheckListSL { get; set; }
        public SelectList FaenasSL { get; set; }
        public SelectList EvidenceTypesSL { get; set; }
        // FIN TODOS LOS SELECT LIST
        public SelectListsPageModel() { }

        public void PopulatePersonasDropDownList(Esecure2.Data.ApplicationDbContext _context,
            object selectedPersona = null)
        {
            var personasQuery = from d in _context.Persona
                                orderby d.PrimerNombre // Sort by name.
                                select d;

            PersonasNameSL = new SelectList(personasQuery.AsNoTracking(),
                        "PersonaID", "PrimerNombre", selectedPersona);
        }
        public void PopulatePersonasDropDownList(Esecure2.Data.ApplicationDbContext _context, int emid,
            object selectedPersona = null)
        {
            var personasQuery = from d in _context.Persona
                                orderby d.PrimerNombre 
                                // Sort by name.
                                select d;

            PersonasNameSL = new SelectList(personasQuery.AsNoTracking(),
                        "PersonaID", "PrimerNombre", selectedPersona);
        }
        public void PopulateEmpresasDropDownList(Esecure2.Data.ApplicationDbContext _context,
            object selectedEmpresa = null)
        {
            var EmpresasQuery = from d in _context.Empresa
                                orderby d.NombreFantasia // Sort by name.
                                select d;

            EmpresasNameSL = new SelectList(EmpresasQuery.AsNoTracking(),
                        "EmpresaID", "NombreFantasia", selectedEmpresa);
        }
        public void PopulateActividadVerificacionDropDownList(Esecure2.Data.ApplicationDbContext _context,
            object selectedActividadVerificacion = null)
        {
            var ActividadVerificacionQuery = from d in _context.ActividadVerificacion
                                             orderby d.Descripcion // Sort by name.
                                             select d;

            ActividadVerificacionNameSL = new SelectList(ActividadVerificacionQuery.AsNoTracking(),
                        "ActividadVerificacionID", "Descripcion", selectedActividadVerificacion);
        }
        public void PopulateCheckListTestDropDownList(Esecure2.Data.ApplicationDbContext _context,
            object selectedTest = null)
        {
            var TestQuery = from d in _context.Test
                            orderby d.Name // Sort by name.
                            select d;

            CheckListSL = new SelectList(TestQuery.AsNoTracking(),
                        "TestID", "Name", selectedTest);
        }
        public void PopulateFaenasDropDownList(Esecure2.Data.ApplicationDbContext _context, int emid, object selectedFaena = null)
        {
            var TestFaenas = from d in _context.Faena
                             where d.EmpresaID == emid
                             orderby d.NombreFaena // Sort by name.

                             select d;

            FaenasSL = new SelectList(TestFaenas.AsNoTracking(),
                        "FaenaID", "NombreFaena", selectedFaena);
        }
        public void PopulateFaenasDropDownList(Esecure2.Data.ApplicationDbContext _context, object selectedFaena = null)
        {
            var TestFaenas = from d in _context.Faena
                                 //where d.EmpresaID==emid
                             orderby d.NombreFaena // Sort by name.                             
                             select d;
            FaenasSL = new SelectList(TestFaenas.AsNoTracking(),
                        "FaenaID", "NombreFaena", selectedFaena);
        }

        public void PopulateETDropDownList(Esecure2.Data.ApplicationDbContext _context, object selectedEvidenceType = null)
        {
            var EvidenceTypes = from d in _context.EvidenceType
                                    //where d.EmpresaID==emid
                                orderby d.EvidenceTypeName // Sort by name.                             
                                select d;
            EvidenceTypesSL = new SelectList(EvidenceTypes.AsNoTracking(),
                            "EvidenceTypeID", "EvidenceTypeName", selectedEvidenceType);
        }
    }
}
