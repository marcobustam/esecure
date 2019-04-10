using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Bbs.Models.Params;
using bbs.Models;
using Esecure2.Data;

namespace Bbs.Pages.Params.WebConfigurations
{
    public class CreateModel : PageModel
    {
        private readonly BbsContext _context;

        public CreateModel(BbsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public EsecureModel.Config.WebConfiguration WebConfiguration { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.WebConfiguration.Add(WebConfiguration);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}