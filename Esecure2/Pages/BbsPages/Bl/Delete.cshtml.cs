//using System.Collections.Generic;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.EntityFrameworkCore;
//using Esecure2.Data;
//using EsecureModel.Bbs.Bussiness;

//namespace Bbs.Pages.Bl
//{
//    public class DeleteModel : PageModel
//    {
//        private readonly BbsContext _context;

//        public DeleteModel(BbsContext context)
//        {
//            _context = context;
//        }

//        [BindProperty]
//        public Inspection Inspection { get; set; }

//        public async Task<IActionResult> OnGetAsync(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            Inspection = await _context.Inspection.FirstOrDefaultAsync(m => m.InspectionID == id);

//            if (Inspection == null)
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

//            Inspection = await _context.Inspection.FindAsync(id);

//            if (Inspection != null)
//            {
//                _context.Inspection.Remove(Inspection);
//                await _context.SaveChangesAsync();
//            }

//            return RedirectToPage("./Index");
//        }
//    }
//}
