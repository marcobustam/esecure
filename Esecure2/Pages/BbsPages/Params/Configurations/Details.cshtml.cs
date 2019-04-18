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

//namespace Bbs.Pages.Params.Configurations
//{
//    public class DetailsModel : PageModel
//    {
//        private readonly BbsContext _context;

//        public DetailsModel(BbsContext context)
//        {
//            _context = context;
//        }

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
//    }
//}
