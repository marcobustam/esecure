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

//namespace Bbs.Pages.Params.Divisions
//{
//    public class EditModel : PageModel
//    {
//        private readonly BbsContext _context;

//        public EditModel(BbsContext context)
//        {
//            _context = context;
//        }

//        [BindProperty]
//        public Division Division { get; set; }

//        public async Task<IActionResult> OnGetAsync(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            Division = await _context.Division.FirstOrDefaultAsync(m => m.DivisionID == id);

//            if (Division == null)
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

//            _context.Attach(Division).State = EntityState.Modified;

//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                if (!DivisionExists(Division.DivisionID))
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

//        private bool DivisionExists(int id)
//        {
//            return _context.Division.Any(e => e.DivisionID == id);
//        }
//    }
//}
