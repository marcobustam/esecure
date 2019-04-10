using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Esecure2.Data;
using EsecureModel.File;
using Microsoft.EntityFrameworkCore;
using EsecureWebApp.Helpers;
using EsecureModel.Usuario;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace EsecureWebApp.Pages.FileUploaders.Folders
{
    public class CreateModel : BaseCodeModel
    {
        private readonly Esecure2.Data.ApplicationDbContext _context;
        public IList<FolderUp> FolderUpList { get; set; }
        public string htmlTree { get; set; }
        public CreateModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
        }

        public async Task OnGet()
        {
            FolderUpList = await _context.FolderUp.ToListAsync();
            foreach (var e in FolderUpList)
            {
                var subfolders = FolderUpList.Where(fo => fo.FolderUpParent == e.FolderUpID).ToList();
                e.FolderUpFolders = subfolders;
            }

            htmlTree = FileUpHelper.GetFolderUpTree(FolderUpList);
            // return Page();
        }

        [BindProperty]
        public FolderUp FolderUp { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.FolderUp.Add(FolderUp);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}