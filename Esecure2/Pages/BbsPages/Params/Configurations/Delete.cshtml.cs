using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using bbs.Models;
using bbs.Models.Params;
using Esecure2.Data;

namespace Bbs.Pages.Params.Configurations
{
    public class DeleteModel : PageModel
    {
        private readonly BbsContext _context;

        public DeleteModel(BbsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Configuration Configuration { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Configuration = await _context.Configuration.FirstOrDefaultAsync(m => m.ConfigurationID == id);

            if (Configuration == null)
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

            Configuration = await _context.Configuration.FindAsync(id);

            if (Configuration != null)
            {
                _context.Configuration.Remove(Configuration);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
