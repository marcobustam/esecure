using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.Faena;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Usuario;

namespace EsecureWebApp.Pages.Mantenedores.Faenas
{
    public class DetailsModel : BaseCodeModel
    {
        // private readonly Esecure2.Data.ApplicationDbContext _context;
        // public Empresa MyEmpresa { get; set; }
        public DetailsModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
        }

        public Faena Faena { get; set; }

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
    }
}
