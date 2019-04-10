using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bbs.Models.Params;
using bbs.Models;
using Esecure2.Data;

namespace Bbs.Pages.Params.WebConfigurations
{
    public class IndexModel : PageModel
    {
        private readonly BbsContext _context;

        public IndexModel(BbsContext context)
        {
            _context = context;
        }

        public IList<EsecureModel.Config.WebConfiguration> WebConfiguration { get;set; }

        public async Task OnGetAsync() => WebConfiguration = await _context.WebConfiguration.ToListAsync();
    }
}
