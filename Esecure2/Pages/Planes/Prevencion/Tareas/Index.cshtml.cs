using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.Planificacion;
using EsecureModel.Faena;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Usuario;

namespace EsecureWebApp.Pages.Planes.Prevencion.Tareas
{
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

        public IList<Tarea> ListaTarea { get;set; }
        [BindProperty]
        public Plan MyPlan { get; set; }
        // [BindProperty]
        // public Empresa MyEmpresa { get; set; }
        public async Task OnGetAsync(int? emid, int? plid)
        {
            if(emid!=null)
            {
                if (plid != null)
                {
                    ListaTarea = await _context.Tarea.Where(ta => ta.PlanID == plid).ToListAsync();
                    MyEmpresa = await _context.Empresa.FirstOrDefaultAsync(m => m.EmpresaID == emid);
                    MyPlan = await _context.Plan.FirstOrDefaultAsync(m => m.PlanID == plid);
                }
                else
                {
                    ListaTarea = await _context.Tarea.Where(ta => ta.EmpresaID==emid).ToListAsync();
                    MyEmpresa = await _context.Empresa.FirstOrDefaultAsync(m => m.EmpresaID == emid);
                    MyPlan = await _context.Plan.FirstOrDefaultAsync(m => m.EmpresaID==emid);
                }
            }
            else
            {                
                ListaTarea = await _context.Tarea.Where(ta => ta.EmpresaID == 0).ToListAsync();
                MyEmpresa = await _context.Empresa.FirstOrDefaultAsync(m => m.EmpresaID == 0);
                MyPlan = await _context.Plan.FirstOrDefaultAsync(m => m.PlanID == 0);
            }
            
        }
        [BindProperty]
        public HistoricoTarea NuevoHistoricoTarea { get; set; }
        public Tarea EstaTarea { get; private set; }

        public async Task<IActionResult> OnPostAsync(int? taid)
        {
            // TODO: Revisar back de la página.
            if (!ModelState.IsValid)
            {
                return Page();
            }
            EstaTarea = await _context.Tarea.FirstOrDefaultAsync(ta => ta.TareaID == NuevoHistoricoTarea.TareaID);
            _context.HistoricoTarea.Add(NuevoHistoricoTarea);
            EstaTarea.EstadoID = NuevoHistoricoTarea.NuevoEstado;
            await _context.SaveChangesAsync();
            var tid = taid;
            return RedirectToPage("./Index", new { emid = EstaTarea.EmpresaID, plid = EstaTarea.PlanID });
            // return RedirectToPage("./Details", "OnGetAsync", routeValues: new { taid = tid });
            //return Page();
        }
    }
}
