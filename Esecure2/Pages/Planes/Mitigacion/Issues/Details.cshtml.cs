using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.Issues;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Usuario;

namespace EsecureWebApp.Pages.Planes.Mitigacion.Issues
{
    public class DetailsModel : BaseCodeModel
    {
        private readonly Esecure2.Data.ApplicationDbContext _context;

        public DetailsModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
        }

        public IssueItem IssueItem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? iiid)
        {
            if (iiid == null)
            {
                return NotFound();
            }

            IssueItem = await _context.IssueItem.FirstOrDefaultAsync(m => m.IssueItemID == iiid);

            if (IssueItem == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
