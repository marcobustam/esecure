using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bbs.Models.Params;
using bbs.Models;
using Esecure2.Data;

namespace Bbs.Pages.Params.WebConfigurations
{
    public class EditModel : PageModel
    {
        private readonly BbsContext _context;

        public EditModel(BbsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public EsecureModel.Config.WebConfiguration WebConfiguration { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            WebConfiguration = await _context.WebConfiguration.FirstOrDefaultAsync(m => m.WebConfigurationID == id);

            if (WebConfiguration == null)
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

            _context.Attach(WebConfiguration).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WebConfigurationExists(WebConfiguration.WebConfigurationID))
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

        private bool WebConfigurationExists(int id)
        {
            return _context.WebConfiguration.Any(e => e.WebConfigurationID == id);
        }
    }
}
