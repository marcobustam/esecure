//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.EntityFrameworkCore;
//using Bbs.Models.Params;
//using bbs.Models;
//using Esecure2.Data;

//namespace Bbs.Pages.Params.WebConfigurations
//{
//    public class DeleteModel : PageModel
//    {
//        private readonly BbsContext _context;

//        public DeleteModel(BbsContext context)
//        {
//            _context = context;
//        }

//        [BindProperty]
//        public EsecureModel.Config.WebConfiguration WebConfiguration { get; set; }

//        public async Task<IActionResult> OnGetAsync(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            WebConfiguration = await _context.WebConfiguration.FirstOrDefaultAsync(m => m.WebConfigurationID == id);

//            if (WebConfiguration == null)
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

//            WebConfiguration = await _context.WebConfiguration.FindAsync(id);

//            if (WebConfiguration != null)
//            {
//                _context.WebConfiguration.Remove(WebConfiguration);
//                await _context.SaveChangesAsync();
//            }

//            return RedirectToPage("./Index");
//        }
//    }
//}
