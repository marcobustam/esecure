using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.File;
using Microsoft.Extensions.Configuration;
using EsecureModel.Usuario;
using Microsoft.AspNetCore.Identity;

namespace EsecureWebApp.Pages.FileUploaders.FileTypes
{
    public class IndexModel : BaseCodeModel
    {
        private readonly Esecure2.Data.ApplicationDbContext _context;

        public IndexModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
        }

        public IList<FileUpType> FileUpType { get;set; }

        public async Task OnGetAsync()
        {
            FileUpType = await _context.FileUpType.ToListAsync();
        }
    }
}
