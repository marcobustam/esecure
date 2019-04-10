using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EsecureWebApp.Pages;
using Esecure2.Data;
using EsecureModel.Usuario;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace Esecure2.Pages
{
    public class AboutModel : BaseCodeModel
    {
        public AboutModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
        }

        public void OnGet()
        {
            Message = "Como iniciar";
        }
    }
}
