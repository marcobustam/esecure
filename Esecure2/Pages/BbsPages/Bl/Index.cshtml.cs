using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.Bbs.Bussiness;

namespace Bbs.Pages.Bl
{
    public class IndexModel : PageModel
    {
        private readonly BbsContext _context;

        public IndexModel(BbsContext context)
        {
            _context = context;
        }

        public IList<Inspection> Inspection { get;set; }

        public async Task OnGetAsync()
        {
            Inspection = await _context.Inspection.ToListAsync();
        }
    }
}
