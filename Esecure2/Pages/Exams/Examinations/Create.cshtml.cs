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

namespace EsecureWebApp.Pages.Exams.Examinations
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
        }

        public IActionResult OnGet()
        {
        ViewData["TestID"] = new SelectList(_context.Test, "TestID", "TestID");
            return Page();
        }

        [BindProperty]
        public Examination Exam { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            // Exam.ExaminationID = -123123;
            Exam.TimeStamp = DateTime.Now;
            // Exam.ExaminationID = null;
            _context.Examination.Add(Exam);
            await _context.SaveChangesAsync();

            // return RedirectToPage("./Details", new { exid = Exam.ExaminationID });
            return RedirectToPage("./Details", new { emid = Exam.EmpresaID, plid = Exam.PlanID, taid = Exam.TareaID, exid = Exam.ExaminationID });
        }
    }
}