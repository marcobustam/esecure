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
using EsecureModel.Usuario;
using Microsoft.AspNetCore.Identity;

namespace EsecureWebApp.Pages.Mantenedores.Empresas
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
        public Empresa Empresa { get; set; }
        public Empresa MyEmpresa { get; set; }
        public async Task<IActionResult> OnGetAsync(int? emid)
        {
            if (emid == null)
            {
                return NotFound();
            }

            Empresa = await _context.Empresa.FirstOrDefaultAsync(m => m.EmpresaID == emid);

            if (Empresa == null)
            {
                return NotFound();
            }
            if (!(emid == null))
            {
                MyEmpresa = await _context.Empresa.FirstOrDefaultAsync(m => m.EmpresaID == emid);
                if (MyEmpresa == null)
                {
                    return NotFound();
                }
            }
            PopulatePersonasDropDownList(_context);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Empresa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpresaExists(Empresa.EmpresaID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            // TODO: redireccion emid
            return RedirectToPage("./Index"); //, var emid = emid);
        }

        private bool EmpresaExists(int emid)
        {
            return _context.Empresa.Any(e => e.EmpresaID == emid);
        }
    }
}
