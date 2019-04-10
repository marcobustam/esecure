using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.Faena;
using EsecureModel.Personal;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Usuario;

namespace EsecureWebApp.Pages.Mantenedores.Empresas
{
    public class IndexModel : BaseCodeModel
    {
        private readonly Esecure2.Data.ApplicationDbContext _context;

        public IndexModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
        }

        public IList<Empresa> Empresa { get;set; }
        public Persona Representante { get; set; }


        public async Task OnGetAsync(int? emid)
        {
            try
            {
                Message = "Empresa!";
                if (emid != null)
                {
                    // = new List<Empresa>();
                    Empresa = await _context.Empresa.Where(em=>em.EmpresaID==emid).ToListAsync();
                    // Empresa.Add(elem);
                    if(Empresa.Count == 1)
                    {
                        Representante = _context.Persona.Where(rep=>rep.PersonaID == Empresa[0].PersonaID).FirstOrDefault();
                    }
                    else
                    {
                        Representante = new Persona();
                    }
                }
                else
                {
                    Empresa = await _context.Empresa.ToListAsync();
                    
                }
            }
            catch (Exception ex)
            {
                RedirectToPage("/Index", new { errorMsg = ex.Message });
            }
        }
    }
}
