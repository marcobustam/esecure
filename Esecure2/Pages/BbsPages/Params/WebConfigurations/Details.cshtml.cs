using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bbs.Models.Params;
using EsecureModel.Config;
using bbs.Models;
using Esecure2.Data;

namespace Bbs.Pages.Params.WebConfigurations
{
    public class DetailsModel : PageModel
    {
        private readonly BbsContext _context;

        public DetailsModel(BbsContext context)
        {
            _context = context;
        }

        public EsecureModel.Config.WebConfiguration WebConfiguration { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            WebConfiguration = await _context.WebConfiguration.FirstOrDefaultAsync(m => m.WebConfigurationID == id);

            if (WebConfiguration == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
