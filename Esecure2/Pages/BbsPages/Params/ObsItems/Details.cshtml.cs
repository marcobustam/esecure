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

//namespace Bbs.Pages.Params.ObsItems
//{
//    public class DetailsModel : PageModel
//    {
//        private readonly BbsContext _context;

//        public DetailsModel(BbsContext context)
//        {
//            _context = context;
//        }

//        public ObsItem ObsItem { get; set; }

//        public async Task<IActionResult> OnGetAsync(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            ObsItem = await _context.ObsItem.FirstOrDefaultAsync(m => m.ObsItemID == id);

//            if (ObsItem == null)
//            {
//                return NotFound();
//            }
//            return Page();
//        }
//    }
//}
