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

namespace Bbs.Pages.Params.ObsCategories
{
    public class EditModel : PageModel
    {
        private readonly BbsContext _context;

        public EditModel(BbsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ObsCategory ObsCategory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? ocid)
        {
            if (ocid == null)
            {
                return NotFound();
            }

            ObsCategory = await _context.ObsCategory.FirstOrDefaultAsync(m => m.ObsCategoryID == ocid);

            if (ObsCategory == null)
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

            _context.Attach(ObsCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObsCategoryExists(ObsCategory.ObsCategoryID))
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

        private bool ObsCategoryExists(int ocid)
        {
            return _context.ObsCategory.Any(e => e.ObsCategoryID == ocid);
        }
    }
}
