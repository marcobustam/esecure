//using System.Threading.Tasks;
//using Esecure2.Data;
//using EsecureModel.Bbs.Bussiness;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;

//namespace Bbs.Pages.BbsInspects
//{
//    public class CreateModel : PageModel
//    {
//        private readonly BbsContext _context;

//        public CreateModel(BbsContext context)
//        {
//            _context = context;
//        }

//        public IActionResult OnGet()
//        {
//            return Page();
//        }

//        [BindProperty]
//        public Inspection Inspection { get; set; }

//        public async Task<IActionResult> OnPostAsync()
//        {
//            if (!ModelState.IsValid)
//            {
//                return Page();
//            }

//            _context.Inspection.Add(Inspection);
//            await _context.SaveChangesAsync();

//            return RedirectToPage("./Index");
//        }
//    }
//}