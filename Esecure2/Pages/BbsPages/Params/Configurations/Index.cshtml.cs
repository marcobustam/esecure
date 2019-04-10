using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using bbs.Models;
using bbs.Models.Params;
using Esecure2.Data;

namespace Bbs.Pages.Params.Configurations
{
    public class IndexModel : PageModel
    {
        private readonly BbsContext _context;

        public IndexModel(BbsContext context)
        {
            _context = context;
        }

        public IList<Configuration> Configuration { get;set; }

        public async Task OnGetAsync()
        {
            Configuration = await _context.Configuration.ToListAsync();
        }
    }
}
