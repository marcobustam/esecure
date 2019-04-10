using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.Config;
using Microsoft.Extensions.Configuration;
using EsecureModel.Usuario;
using Microsoft.AspNetCore.Identity;

namespace EsecureWebApp.Pages.WebConfigurations
{
    public class EditModel : BaseCodeModel
    {
        private readonly Esecure2.Data.ApplicationDbContext _context;

        public EditModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
        }

        [BindProperty]
        public WebConfiguration WebConfiguration { get; set; }

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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(WebConfiguration).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WebConfigurationExists(WebConfiguration.WebConfigurationID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool WebConfigurationExists(int id)
        {
            return _context.WebConfiguration.Any(e => e.WebConfigurationID == id);
        }
    }
}
