using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using bbs.Models;
using bbs.Models.Params;
using Esecure2.Data;

namespace Bbs.Pages.Params.ObsItems
{
    public class EditModel : PageModel
    {
        private readonly BbsContext _context;

        public EditModel(BbsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ObsItem ObsItem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ObsItem = await _context.ObsItem.FirstOrDefaultAsync(m => m.ObsItemID == id);

            if (ObsItem == null)
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

            _context.Attach(ObsItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObsItemExists(ObsItem.ObsItemID))
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

        private bool ObsItemExists(int id)
        {
            return _context.ObsItem.Any(e => e.ObsItemID == id);
        }
    }
}
