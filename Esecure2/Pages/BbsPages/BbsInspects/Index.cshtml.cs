//using System.Collections.Generic;
//using System.Threading.Tasks;
//using Esecure2.Data;
//using EsecureModel.Bbs.Bussiness;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.EntityFrameworkCore;

//namespace Bbs.Pages.BbsInspects
//{
//    public class IndexModel : PageModel
//    {
//        private readonly BbsContext _context;

//        public IndexModel(BbsContext context)
//        {
//            _context = context;
//        }

//        public IList<Inspection> Inspection { get;set; }

//        public async Task OnGetAsync()
//        {
//            Inspection = await _context.Inspection.ToListAsync();
//        }
//    }
//}
