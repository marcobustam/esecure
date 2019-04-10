using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using bbs.Models.Params;
using Esecure2.Data;

namespace Bbs.Pages.Params.Persons
{
    public class EditModel : PageModel
    {
        private readonly BbsContext _context;

        public EditModel(BbsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Person ThisPerson { get; set; }

        public async Task<IActionResult> OnGetAsync(int? peid)
        {
            if (peid == null)
            {
                return NotFound();
            }

            ThisPerson = await _context.Person.FirstOrDefaultAsync(m => m.PersonID == peid);

            if (ThisPerson == null)
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

            _context.Attach(ThisPerson).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonExists(ThisPerson.PersonID))
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

        private bool PersonExists(int peid)
        {
            return _context.Person.Any(e => e.PersonID == peid);
        }
    }
}
