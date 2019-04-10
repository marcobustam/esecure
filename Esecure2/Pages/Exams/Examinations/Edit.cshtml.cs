using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.Exam;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Usuario;

namespace EsecureWebApp.Pages.Exams.Examinations
{
    public class EditModel : BaseCodeModel
    {
        private readonly Esecure2.Data.ApplicationDbContext _context;

        public EditModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
        }

        [BindProperty]
        public Examination Examination { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Examination = await _context.Examination
                .Include(e => e.Prueba).FirstOrDefaultAsync(m => m.ExaminationID == id);

            if (Examination == null)
            {
                return NotFound();
            }
           ViewData["TestID"] = new SelectList(_context.Test, "TestID", "TestID");
            return Page();
        }
        [ActionName("OnGetAsync2")]
        public async Task<IActionResult> OnGetAsync2(int emid, int plid, int taid)
        {
            /*
            if (id == null)
            {
                return NotFound();
            }
            */
            Examination = await _context.Examination
                .Include(e => e.Prueba).FirstOrDefaultAsync(m => m.TareaID == taid);

            if (Examination == null)
            {
                return NotFound();
            }
           ViewData["TestID"] = new SelectList(_context.Test, "TestID", "TestID");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Examination).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExaminationExists(Examination.ExaminationID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ExaminationExists(int id)
        {
            return _context.Examination.Any(e => e.ExaminationID == id);
        }
    }
}
