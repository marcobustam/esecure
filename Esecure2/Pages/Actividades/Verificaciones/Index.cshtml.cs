using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.Verificaciones;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Usuario;

namespace EsecureWebApp.Pages.Actividades.Verificaciones
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

        public IList<ActividadVerificacion> ListaActividadVerificacion { get;set; }
        /*
        public async Task OnGetAsync()
        {
            ListaActividadVerificacion = await _context.ActividadVerificacion.ToListAsync();
        }*/
        public async Task OnGetAsync(int? emid,int? plid)
        {
            if (!(emid == null))
            {
                ListaActividadVerificacion = await _context.ActividadVerificacion.Where(ac => ac.EmpresaID == emid).ToListAsync();
            }
            else
            {
                ListaActividadVerificacion = await _context.ActividadVerificacion.ToListAsync();
            }
        }
        /*
        public async Task OnGetAsync(int? emid)
        {
            if (!(emid == null))
            {
                ListaActividadVerificacion = await _context.ActividadVerificacion.Where(ac => ac.EmpresaID == emid).ToListAsync();
            }
            else
            {
                ListaActividadVerificacion = await _context.ActividadVerificacion.ToListAsync();
            }
        }*/
    }
}
