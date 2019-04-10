using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Esecure2.Data;
using EsecureModel.Faena;
using EsecureModel;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Usuario;

namespace EsecureWebApp.Pages.Mantenedores.Empresas
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
            return Page();
        }

        [BindProperty]
        public Empresa Empresa { get; set; }
        //public EsecureModel.Utiles Utilex { get; private set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            /*
            if(!Utiles.validarRut(Empresa.RutChile))
            {
                Message = "Rut inválido";
            }
            */
            
            _context.Empresa.Add(Empresa);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index", new { emid = Empresa.EmpresaID } );
            //return RedirectToPage("./Details", new { exid = ResponseItem.ExaminationID });
        }
    }
}