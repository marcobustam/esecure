using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.Faena;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Usuario;

namespace EsecureWebApp.Pages.Mantenedores.Faenas
{
    public class EditModel : BaseCodeModel
    {
        // private readonly Esecure2.Data.ApplicationDbContext _context;

        public EditModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
        }

        [BindProperty]
        public Faena Faena { get; set; }
        // public Empresa MyEmpresa { get; set; }
        public async Task<IActionResult> OnGetAsync(int? emid, int? faid)
        {
            if (emid == null)
            {
                return RedirectToPage("/Index", new { errorMsg = "No se ha suministrado el código de empresa." });
            }
            MyEmpresa = await _context.Empresa.FindAsync(emid);
            if (faid == null)
            {
                return NotFound();
            }

            Faena = await _context.Faena.FirstOrDefaultAsync(m => m.FaenaID == faid);

            if (Faena == null)
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
            Faena.Umod = DateTime.Now;

            _context.Attach(Faena).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FaenaExists(Faena.FaenaID))
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {
                return RedirectToPage("/Error", new { errorMsg = e.Message });
            }

            return RedirectToPage("./Index", new { emid = Faena.EmpresaID });
        }

        private bool FaenaExists(int id)
        {
            return _context.Faena.Any(e => e.FaenaID == id);
        }
    }
}
