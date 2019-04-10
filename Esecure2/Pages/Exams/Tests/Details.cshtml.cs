using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.Exam;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Usuario;

namespace EsecureWebApp.Pages.Exams.Tests
{
    public class DetailsModel : BaseCodeModel
    {
        private readonly Esecure2.Data.ApplicationDbContext _context;

        public DetailsModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
        }
        [BindProperty]
        public Question Question { get; set; }
        public Test Test { get; set; }
        public List<Question> QuestionList { get; set; }
        public  List<Category> CategoryList { get; set; }
        public SelectList CategorySL { get; set; }

        public async Task<IActionResult> OnGetAsync(int? teid)
        {
            if (teid == null)
            {
                return NotFound();
            }
            CategoryList = await _context.Category.ToListAsync();
            // var name = CategoryList.ElementAt(1);
            CategorySL = new SelectList(CategoryList, "CategoryID", "Name");
            ViewData["CategoryList"] = CategorySL;
            ViewData["teid"] = teid;

            Test = await _context.Test.FirstOrDefaultAsync(m => m.TestID == teid);

            QuestionList = await _context.Question.Where(q => q.TestID == teid).OrderBy(ql=>ql.CategoryID).ThenBy(quid=>quid.QuestionID).ToListAsync();
            if (Test == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Question.Add(Question);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Details", new { teid = Question.TestID });
        }
    }
}
