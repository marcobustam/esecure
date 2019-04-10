using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Esecure2.Data;
using EsecureModel.Exam;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Usuario;

namespace EsecureWebApp.Pages.Exams.Questions
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

        public async Task<IActionResult> OnGet(int? teid)
        {
            CategoryList = await _context.Category.ToListAsync();
            CategorySL = new SelectList(CategoryList, "CategoryID", "Name");
            ViewData["CategoryList"] = CategorySL;
            ViewData["teid"] = teid;
            return Page();
        }

        [BindProperty]
        public Question Question { get; set; }
        private List<Category> CategoryList { get; set; }
        public SelectList CategorySL { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Question.Add(Question);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}