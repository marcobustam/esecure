using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.File;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.Extensions.Configuration;
using EsecureModel.Usuario;
using Microsoft.AspNetCore.Identity;

namespace EsecureWebApp.Pages.FileUploaders.Files
{
    public class IndexModel : BaseCodeModel
    {
        // private readonly Esecure2.Data.ApplicationDbContext _context;
        private readonly IHostingEnvironment _environment;
        public IndexModel(IHostingEnvironment environment, IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
            _environment = environment;
        }

        public IList<FileUp> FileUp { get;set; }
        public string FilePath { get; set; }
        public async Task OnGetAsync(int error=0)
        {
            if((int)error>0)
            {
                Message = "Error al descargar archivo";
            }
            FileUp = await _context.FileUp.ToListAsync();
            FilePath = Path.Combine(_environment.ContentRootPath, "Data", "Uploads");
        }
        public PhysicalFileResult PhysicalFileActionResult(string filePath, string fileName, string fileUid)
        {
            // FileUp = await _context.FileUp.ToListAsync();
            // FilePath = Path.Combine(_environment.ContentRootPath, "Data", "Uploads");
            return PhysicalFile(FilePath = Path.Combine(_environment.ContentRootPath, filePath, fileUid), "text/plain", fileName);
        }
        public PhysicalFileResult DownloadFile(string filePath, string fileName, string fileUid)
        {
            return PhysicalFile(Path.Combine(FilePath, fileUid), "text/plain", fileName);
        }
    }
}
