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
//    public class DetailsModel : PageModel
//    {
//        private readonly BbsContext _context;

//        public DetailsModel(BbsContext context)
//        {
//            _context = context;
//        }

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
//    }
//}
