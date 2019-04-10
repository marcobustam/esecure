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

namespace Bbs.Pages.Params.RespTypes
{
    public class EditModel : PageModel
    {
        private readonly BbsContext _context;

        public EditModel(BbsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public RespType RespType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RespType = await _context.RespType.FirstOrDefaultAsync(m => m.RespTypeID == id);

            if (RespType == null)
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

            _context.Attach(RespType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RespTypeExists(RespType.RespTypeID))
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

        private bool RespTypeExists(int id)
        {
            return _context.RespType.Any(e => e.RespTypeID == id);
        }
    }
}
