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

namespace Bbs.Pages.Params.ObsCategories
{
    public class DetailsModel : PageModel
    {
        private readonly BbsContext _context;

        public DetailsModel(BbsContext context)
        {
            _context = context;
        }

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
    }
}
