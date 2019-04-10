using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Esecure2.Data;
using EsecureModel.Exam;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Usuario;

namespace EsecureWebApp.Pages.Exams.Evidences
{
    public class CreateModel : BaseCodeModel
    {
        private readonly Esecure2.Data.ApplicationDbContext _context;

        public CreateModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
            PopulateETDropDownList(_context,null);
        }

        public IActionResult OnGet()
        {
            /// ViewData["FileUpID"] = new SelectList(_context.FileUp, "FileUpID", "FileName");
            // ViewData["FileUpID"] = 
            ViewData["EvidenceType"] = EvidenceTypesSL;
            return Page();
        }

        [BindProperty]
        public Evidence Evidence { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Evidence.Add(Evidence);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}