using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.Planificacion;
using EsecureModel.Personal;
using EsecureModel.Faena;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Usuario;

namespace EsecureWebApp.Pages.Planes.Prevencion.Planificaciones
{
    // TODO: Agregar el soporte para desactivar planes y no eliminarlos de la base de datos.
    // TODO: Agregar histórico de modificaciones.
    public class IndexModel : BaseCodeModel
    {
        // private readonly Esecure2.Data.ApplicationDbContext _context;

        public IndexModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
        }

        public IList<Plan> PlanList { get;set; }
        // public Empresa MyEmpresa { get; set; }
        public IList<Persona> ListaResponsables { get; set; }
        public IList<Empresa> ListaEmpresas { get; set; }
        public async Task OnGetAsync(int? emid)
        {
            try
            {
                // Muestra todos
                if (!(emid == null))
                {
                    // TODO: Agregar estados y filtrar por estado.
                    MyEmpresa = await _context.Empresa.FirstOrDefaultAsync(e => e.EmpresaID == emid);
                    PlanList = await _context.Plan.Include(pl => pl.Persona).Where(p => p.EmpresaID == emid).ToListAsync();
                    ListaResponsables = await _context.Persona.ToListAsync();
                    ListaEmpresas = await _context.Empresa.ToListAsync();
                }
                else
                {
                    MyEmpresa = new Empresa();
                    PlanList = await _context.Plan.Include(pl => pl.Persona).ToListAsync();
                    ListaResponsables = await _context.Persona.ToListAsync();
                    ListaEmpresas = await _context.Empresa.ToListAsync();
                }
            }
            catch (Exception e)
            {

            }
            finally
            {

            }

        }
    }
}

