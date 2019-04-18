//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;

//using bbs.Models.Params;
//using Esecure2.Data;

//namespace Bbs.Pages.Params.Configurations
//{
//    public class EditModel : PageModel
//    {
//        private readonly BbsContext _context;

//        public EditModel(BbsContext context)
//        {
//            _context = context;
//        }

//        [BindProperty]
//        public Configuration Configuration { get; set; }

//        public async Task<IActionResult> OnGetAsync(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            Configuration = await _context.Configuration.FirstOrDefaultAsync(m => m.ConfigurationID == id);

//            if (Configuration == null)
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

//            _context.Attach(Configuration).State = EntityState.Modified;

//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                if (!ConfigurationExists(Configuration.ConfigurationID))
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

//        private bool ConfigurationExists(int id)
//        {
//            return _context.Configuration.Any(e => e.ConfigurationID == id);
//        }
//    }
//}
