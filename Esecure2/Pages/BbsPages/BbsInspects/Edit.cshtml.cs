//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.EntityFrameworkCore;
//using Esecure2.Data;
//using EsecureModel.Bbs.Bussiness;

//namespace Bbs.Pages.BbsInspects
//{
//    public class EditModel : PageModel
//    {
//        private readonly BbsContext _context;

//        public EditModel(BbsContext context)
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

//        public async Task<IActionResult> OnPostAsync()
//        {
//            if (!ModelState.IsValid)
//            {
//                return Page();
//            }

//            _context.Attach(Inspection).State = EntityState.Modified;

//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                if (!InspectionExists(Inspection.InspectionID))
//                {
//                    return base.NotFound();
//                }
//                else
//                {
//                    throw;
//                }
//            }

//            return RedirectToPage("./Index");
//        }

//        private bool InspectionExists(int id)
//        {
//            return _context.Inspection.Any(e => e.InspectionID == id);
//        }
//    }
//}
