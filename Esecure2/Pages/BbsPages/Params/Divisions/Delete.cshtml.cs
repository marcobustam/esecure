//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.EntityFrameworkCore;
//using bbs.Models;
//using bbs.Models.Params;
//using Esecure2.Data;

//namespace Bbs.Pages.Params.Divisions
//{
//    public class DeleteModel : PageModel
//    {
//        private readonly BbsContext _context;

//        public DeleteModel(BbsContext context)
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

//        public async Task<IActionResult> OnPostAsync(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            Division = await _context.Division.FindAsync(id);

//            if (Division != null)
//            {
//                _context.Division.Remove(Division);
//                await _context.SaveChangesAsync();
//            }

//            return RedirectToPage("./Index");
//        }
//    }
//}
