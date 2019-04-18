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

//namespace Bbs.Pages.Params.RespTypes
//{
//    public class IndexModel : PageModel
//    {
//        private readonly BbsContext _context;

//        public IndexModel(BbsContext context)
//        {
//            _context = context;
//        }

//        public IList<RespType> RespType { get;set; }

//        public async Task OnGetAsync()
//        {
//            RespType = await _context.RespType.ToListAsync();
//        }
//    }
//}
