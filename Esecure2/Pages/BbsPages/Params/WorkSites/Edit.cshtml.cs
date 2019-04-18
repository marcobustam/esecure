//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using bbs.Models;
//using bbs.Models.Params;
//using Esecure2.Data;

//namespace Bbs.Pages.Params.WorkSites
//{
//    public class EditModel : PageModel
//    {
//        private readonly BbsContext _context;

//        public EditModel(BbsContext context)
//        {
//            _context = context;
//        }

//        [BindProperty]
//        public WorkSite WorkSite { get; set; }

//        public async Task<IActionResult> OnGetAsync(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            WorkSite = await _context.WorkSite.FirstOrDefaultAsync(m => m.WorkSiteID == id);

//            if (WorkSite == null)
//            {
//                return NotFound();
//            }
//            return Page();
//        }

//        public async Task<IActionResult> OnPostAsync()
//        {
//            if (!ModelState.IsValid)
//            {
//                return Page();
//            }

//            _context.Attach(WorkSite).State = EntityState.Modified;

//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                if (!WorkSiteExists(WorkSite.WorkSiteID))
//                {
//                    return NotFound();
//                }
//                else
//                {
//                    throw;
//                }
//            }

//            return RedirectToPage("./Index");
//        }

//        private bool WorkSiteExists(int id)
//        {
//            return _context.WorkSite.Any(e => e.WorkSiteID == id);
//        }
//    }
//}
