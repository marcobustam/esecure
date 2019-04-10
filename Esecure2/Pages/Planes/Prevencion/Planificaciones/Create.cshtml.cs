using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Esecure2.Data;
using EsecureModel.Planificacion;
using EsecureWebApp.Pages.Mantenedores.Var;
using EsecureModel.Issues;
using EsecureModel.Faena;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Usuario;

namespace EsecureWebApp.Pages.Planes.Prevencion.Planificaciones
{
    public class CreateModel : BaseCodeModel
    {
        // private readonly ApplicationDbContext _context;

        public CreateModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
        }
        // [BindProperty]
        // public Empresa MyEmpresa { get; set; }
        public async Task<IActionResult> OnGet(int? emid)
        {
            if(!(emid==null))
            {
                MyEmpresa = await _context.Empresa.FirstOrDefaultAsync(m => m.EmpresaID == emid);
                if (MyEmpresa == null)
                {
                    return NotFound();
                }
            }
            //_context.Persona.Local.
            PopulatePersonasDropDownList(_context);
            PopulateEmpresasDropDownList(_context);
            //Personas = new SelectList(_context.Persona, "ID", "PrimerNombre");
            /*NewPlan = new Plan()
            {
                NombrePlan = " Plan 01 ",
                EmpresaID = 0,
                PersonaID = 0
            };*/
            return Page();
        }

        [BindProperty]
        public Plan NewPlan { get; set; }
        //public SelectList Personas { get; set; }

        public List<Plan> PlanList { get; set; }

        // Crear un Plan de Prevencion
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            try
            {
                // Rescatamos la empresa
                MyEmpresa = await _context.Empresa.FirstOrDefaultAsync(m => m.EmpresaID == NewPlan.EmpresaID);
                // Enlazamos el Plan con la Empresa
                NewPlan.Empresa = MyEmpresa;
                // Revisamos si la empresa ya tiene una lista de planes de prevención
                PlanList = await _context.Plan.Where(pl => pl.EmpresaID == MyEmpresa.EmpresaID).ToListAsync();
                // si no tiene lista de planes agregamos una nueva Lista
                MyEmpresa.Planes = PlanList ?? new List<Plan>();
                // agregamos el plan a la lista de planes 
                MyEmpresa.Planes.Add(NewPlan);
                // agregamos el plan a la tabla de planes
                _context.Plan.Add(NewPlan);
                // agregamos una lista de Tareas
                NewPlan.ListaTareas = new ListaDeTareas(NewPlan.PlanID);
                // agregamos una lista de Issues
                NewPlan.ListaDeIssues = new IssueList(NewPlan.PlanID);
                await _context.SaveChangesAsync();
                // TODO: Redireccionar con emid / plid
                return RedirectToPage("./Index", new { emid = MyEmpresa.EmpresaID });
            }
            catch (Exception ex)
            {
                return RedirectToPage("/Index", new { errorMsg = ex.Message });
            }            
        }
    }
}