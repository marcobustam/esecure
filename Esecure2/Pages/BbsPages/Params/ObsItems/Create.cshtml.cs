using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using bbs.Models;
using bbs.Models.Params;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;

namespace Bbs.Pages.Params.ObsItems
{
    public class CreateModel : PageModel
    {
        private readonly BbsContext _context;
        public IList<ObsItem> ObsItemList { get; set; }
        public IList<ObsCategory> ObsCatList { get; set; }
        [BindProperty]
        public ObsItem ObsItem { get; set; }
        public SelectList SlCategories { get; private set; }

        private SelectList GetSlCategorias()
        {
            var QrCategories = from d in _context.ObsCategory
                               orderby d.ObsCategoryID // Sort by name.
                               select d;

            return new SelectList(QrCategories.AsNoTracking(),
                        "ObsCategoryID", "ObsCategoryDescription", null);

        }


        public CreateModel(BbsContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            ObsCatList = await _context.ObsCategory.ToListAsync();
            ObsItemList = await _context.ObsItem.ToListAsync();
            SlCategories = GetSlCategorias();
            return Page();
        }

        
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ObsItem.Add(ObsItem);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Create");
        }
        
    }
}