using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.Planificacion;

namespace EsecureWebApp.Pages.Planes.Prevencion.Tasks
{
    public class DeleteModel : PageModel
    {
        private readonly Esecure2.Data.ApplicationDbContext _context;

        public DeleteModel(Esecure2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Tarea Tarea { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Tarea = await _context.Tarea.FirstOrDefaultAsync(m => m.TareaID == id);

            if (Tarea == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Tarea = await _context.Tarea.FindAsync(id);

            if (Tarea != null)
            {
                _context.Tarea.Remove(Tarea);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
