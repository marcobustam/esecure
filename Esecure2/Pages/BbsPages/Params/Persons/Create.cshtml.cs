using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using bbs.Models;
using bbs.Models.Params;
using Bbs.Models.Helpers;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;

namespace Bbs.Pages.Params.Persons
{
    public class CreateModel : PageModel
    {
        private readonly BbsContext _context;
        private SelectListHelper _select;
        public SelectList Sl { get; private set; }
        public CreateModel(BbsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            //Sl = _select.GetPersonasDropDownList(_context);
            // Sl = SelectListHelper.GetPersonasDropDownList(_context);
            //Sl = _context.Person.ToList():
            var personasQuery = from d in _context.Person
                                orderby d.Names // Sort by name.
                                select d;

            Sl = new SelectList(personasQuery.AsNoTracking(),
                        "PersonID", "Names", null);
            return Page();
        }

        [BindProperty]
        public Person ThisPerson { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Person.Add(ThisPerson);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}