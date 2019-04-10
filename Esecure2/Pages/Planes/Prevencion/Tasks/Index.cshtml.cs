using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.Planificacion;
using EsecureModel.Faena;

namespace EsecureWebApp.Pages.Planes.Prevencion.Tasks
{
    public class IndexModel : PageModel
    {
        private readonly Esecure2.Data.ApplicationDbContext _context;

        public IndexModel(Esecure2.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public Empresa MyEmpresa { get; set; }
        public IList<Tarea> Tarea { get;set; }

        public async Task OnGetAsync()
        {
            Tarea = await _context.Tarea.ToListAsync();
        }
    }
}
