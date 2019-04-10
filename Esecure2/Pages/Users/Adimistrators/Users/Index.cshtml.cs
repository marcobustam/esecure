using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EsecureWebApp.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EsecureModel.Usuario;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Esecure2.Data;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Faena;

namespace EsecureWebApp.Pages.Users.Adimistrators.Users
{
    public class IndexModel : BaseCodeModel
    {

        // private readonly Esecure2.Data.ApplicationDbContext _context;
        

        public IndexModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
        }
        // public Empresa MyEmpresa { get; set; }
        public IList<ApplicationUser> ApplicationUsers { get; set; }

        public async Task OnGetAsync()
        {
            ApplicationUsers = await _context.ApplicationUser.ToListAsync();
        }
    }
}