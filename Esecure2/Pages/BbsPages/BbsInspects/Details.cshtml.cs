////using System.Threading.Tasks;
////using Microsoft.AspNetCore.Mvc;
////using Microsoft.AspNetCore.Mvc.RazorPages;
////using Microsoft.EntityFrameworkCore;
////using Esecure2.Data;
////using EsecureModel.Bbs.Bussiness;

////namespace Bbs.Pages.BbsInspects
////{
////    public class DetailsModel : PageModel
////    {
////        private readonly BbsContext _context;

////        public DetailsModel(BbsContext context)
////        {
////            _context = context;
////        }

////        public Inspection Inspection { get; set; }

////        public async Task<IActionResult> OnGetAsync(int? id)
////        {
////            if (id == null)
////            {
////                return NotFound();
////            }

////            Inspection = await _context.Inspection.FirstOrDefaultAsync(m => m.InspectionID == id);

////            if (Inspection == null)
////            {
////                return NotFound();
////            }
////            return Page();
////        }
////    }
////}
