using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Esecure2.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Usuario;

namespace EsecureWebApp.Pages.FileUploaders.Files
{
    public class DownloadFileModel : BaseCodeModel
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _environment;
        public string FilePath { get; set; }
        public DownloadFileModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
        }
        public ActionResult OnGet(int? id)
        {
            var fileUp = _context.FileUp.Find((int)id);

            try
            {
                FilePath = Path.Combine(_environment.ContentRootPath, "Data", "Uploads");
                /*
                return PhysicalFile(Path.Combine(FilePath, fileUp.FileUid), "text/plain", fileUp.FileName);
                */
                // var fileName = $"{V9.Version}.exe";
                var filepath = Path.Combine(FilePath, fileUp.FileUid);
                if(System.IO.File.Exists(filepath))
                {
                    byte[] fileBytes = System.IO.File.ReadAllBytes(filepath);
                    return File(fileBytes, "application/x-msdownload", fileUp.FileName);
                }
                else
                {
                    return Redirect("/FileUploaders/Files/Index?error=" + fileUp.FileUpID);
                }
                
            }
            catch (Exception e)
            {
                Message = "no se encuentra el archivo: " + e.Message;
                return null;
            }
            
        }
    }
}