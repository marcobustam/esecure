using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Esecure2.Data;
using EsecureModel.Usuario;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EsecureWebApp.Pages.Users.UserProfiles
{
    public class UserProfileModel : BaseCodeModel
    {
        public UserProfileModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _context = context;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _roleManager = RoleManager;
        }

        public async Task OnGetAsync()
        {
            AppUser = await _userManager.GetUserAsync(User);

            MyEmpresa = await _context.Empresa.FirstOrDefaultAsync(m => m.EmpresaID == AppUser.EmpresaID);


        }
    }
}