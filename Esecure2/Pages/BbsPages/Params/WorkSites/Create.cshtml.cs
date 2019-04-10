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

namespace Bbs.Pages.Params.WorkSites
{
    public class CreateModel : PageModel
    {
        private readonly BbsContext _context;
        public SelectList SlSites { get; private set; }
        public IList<WorkSite> WorkSiteList { get; set; }
        [BindProperty]
        public WorkSite WorkSite { get; set; }

        public CreateModel(BbsContext context)
        {
            _context = context;
        }
        private SelectList getSlSites()
        {
            var QrSites = from d in _context.Site
                          orderby d.SiteName // Sort by name.
                          select d;

            return new SelectList(QrSites.AsNoTracking(),
                        "SiteID", "SiteName", null);
        }

        public async Task<IActionResult> OnGetAsync()
        {
            SlSites = getSlSites();
            WorkSiteList = await _context.WorkSite.ToListAsync();
            return Page();
        }



        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.WorkSite.Add(WorkSite);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Create");
        }
    }
}