using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.Planificacion;

namespace EsecureWebApp.Pages.Planes.Prevencion.Tasks
{
    public class EditModel : PageModel
    {
        private readonly Esecure2.Data.ApplicationDbContext _context;

        public EditModel(Esecure2.Data.ApplicationDbContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Tarea).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TareaExists(Tarea.TareaID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TareaExists(int id)
        {
            return _context.Tarea.Any(e => e.TareaID == id);
        }
    }
}
