using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Esecure2.Data;
using EsecureModel.Faena;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using EsecureModel.Usuario;
using Microsoft.AspNetCore.Identity;

namespace EsecureWebApp.Pages.Mantenedores.Faenas
{
    public class CreateModel : BaseCodeModel
    {
        // private readonly Esecure2.Data.ApplicationDbContext _context;

        public CreateModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
        }
        // public Empresa MyEmpresa { get; set; }
        public IList<Faena> ListaFaenas { get; set; }
                
        public async Task<IActionResult> OnGet(int? emid)
        {
            if(emid==null)
            {
                return RedirectToPage("/Index", new { errorMsg = "No se ha suministrado el código de empresa." } );
            }

            MyEmpresa = await _context.Empresa.FindAsync(emid);
            ListaFaenas = await _context.Faena.Where(fa=>fa.EmpresaID==emid).ToListAsync();
            return Page();
            
        }

        [BindProperty]
        public Faena NuevaFaena { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            NuevaFaena.Timestamp = DateTime.Now;
            NuevaFaena.Umod = DateTime.Now;
            _context.Faena.Add(NuevaFaena);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Create", new { emid = NuevaFaena.EmpresaID } );
        }
    }
}