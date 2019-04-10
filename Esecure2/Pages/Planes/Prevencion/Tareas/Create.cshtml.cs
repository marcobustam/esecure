using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Esecure2.Data;
using EsecureModel.Planificacion;
using EsecureModel.Faena;
using Microsoft.EntityFrameworkCore;
using EsecureModel.Personal;
using EsecureWebApp.Pages.Mantenedores.Var;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Usuario;

namespace EsecureWebApp.Pages.Planes.Prevencion.Tareas
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

        public async Task<IActionResult> OnGet(int? emid, int? plid)
        {
            if(plid==null)
            {
                return Page();
            }

            PopulatePersonasDropDownList(_context);
            PopulateEmpresasDropDownList(_context);
            PopulateCheckListTestDropDownList(_context);
            // MyPlan = await _context.Plan.FirstOrDefaultAsync(pl => pl.EmpresaID == emid && pl.PlanID == plid);
            /*
            if (!(emid==null))
            {
                MyPlan = await _context.Plan.FirstOrDefaultAsync(pl => pl.EmpresaID == emid && pl.PlanID == plid);
                MyEmpresa = await _context.Empresa.FirstOrDefaultAsync(m => m.EmpresaID == emid);

            }
            else
            {
            */
            MyPlan = await _context.Plan.FirstOrDefaultAsync(pl => pl.PlanID == plid);
            MyEmpresa = await _context.Empresa.FirstOrDefaultAsync(m => m.EmpresaID == MyPlan.EmpresaID);
            /* } */
            // TODO: hacer las verificaciones de navegación y levantar los logs y mensajes correspondientes
            MyEncargado = await _context.Persona.FirstOrDefaultAsync(pe => pe.PersonaID == MyPlan.PersonaID);
            EstaTarea = new Tarea
            {
                EstadoID = 0,
                NombreTarea = "",
                PlanID = MyPlan.PlanID,
                EmpresaID=MyEmpresa.EmpresaID

            };

            // EstaTarea.
            return Page();
        }

        [BindProperty]
        public Tarea EstaTarea { get; set; }
        public Tarea NuevaTarea { get; set; }
        [BindProperty]
        public Empresa MyEmpresa { get; set; }
        [BindProperty]
        public Plan MyPlan { get; set; }
        [BindProperty]
        public Persona MyEncargado { get; set; }

        public async Task<IActionResult> OnPostAsync(Tarea t)
        {
            /*
            if (!ModelState.IsValid)
            {
                return Page();
            }
            // Enlazar con el plan
            MyPlan.ListaTareas.AddTarea(EstaTarea);
            // enviamos nueva tarea al histórico
            var historicoTarea = new HistoricoTarea(EstaTarea);
            _context.HistoricoTarea.Add(historicoTarea);
            _context.Tarea.Add(EstaTarea);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index", new { emid = EstaTarea.EmpresaID, plid = EstaTarea.PlanID });
            */
            if (!ModelState.IsValid)
            {
                return Page();
            }
            EstaTarea.EstadoID = 0;
            await _context.SaveChangesAsync();
            var plan = await _context.Plan.Include(pl => pl.ListaTareas).Where(pl => pl.PlanID == EstaTarea.PlanID).FirstOrDefaultAsync();
            plan.ListaTareas.AddTarea(EstaTarea);
            await _context.SaveChangesAsync();
            var historicoTarea = new HistoricoTarea(EstaTarea);
            _context.HistoricoTarea.Add(historicoTarea);

            await _context.SaveChangesAsync();
            return RedirectToPage("Exams/Examinations/Details", new { emid = EstaTarea.EmpresaID, plid = EstaTarea.PlanID });
        }
    }
}