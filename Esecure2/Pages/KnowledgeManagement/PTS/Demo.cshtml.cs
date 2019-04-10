using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Esecure2.Data;
using EsecureModel.Usuario;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace EsecureWebApp.Pages.KnowledgeManagement.PTS
{
    public class DemoModel : BaseCodeModel
    {
        public DemoModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
        }

        public void OnGet()
        {

        }
    }
}