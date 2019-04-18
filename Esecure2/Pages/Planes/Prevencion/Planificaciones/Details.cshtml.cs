using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.Planificacion;
using EsecureWebApp.Pages.Planes.Prevencion.Tareas;
using EsecureWebApp.Pages.Mantenedores.Var;
using EsecureModel.Faena;
using EsecureModel.Exam;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Usuario;
using Microsoft.Extensions.Configuration;
using EsecureWebApp.Mailers;

namespace EsecureWebApp.Pages.Planes.Prevencion.Planificaciones
{
    [BindProperties]
    public class DetailsModel : BaseCodeModel
    {        
        //private readonly Esecure2.Data.ApplicationDbContext _context;
        [BindProperty]
        public Plan MyPlan { get; set; }
        // public _TaskListModel PlanTareas { get; set; }
        public List<Tarea> ListaTareas { get; set; }
        public Tarea NewTarea { get; set; }
        // public Empresa MyEmpresa { get; set; }
        [BindProperty]
        public Examination Exam { get; set; }
        public IList<Examination> ExamList { get; set; }
        public DetailsModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
            // EmailHelper = new EmailHelper(_configuration, context);
            EmailHelper = new EmailHelper(context);//PopulateActividadVerificacionDropDownList(_context);
            PopulateCheckListTestDropDownList(_context);
        }

        public async Task<IActionResult> OnGetAsync(int? emid, int? plid)
        {
            // Plan not found
            if (plid == null)
            {
                return NotFound();
            }
            if (emid==null)
            {
                return NotFound();
            }
            // PopulateActividadVerificacionDropDownList(_context);
            PopulateCheckListTestDropDownList(_context);
            PopulateFaenasDropDownList(_context, (int )emid, null);
            MyEmpresa = await _context.Empresa.FirstOrDefaultAsync(m => m.EmpresaID == emid);
            MyPlan = await _context.Plan.Include(pl => pl.Persona).FirstOrDefaultAsync(m => m.PlanID == plid);
            ListaTareas = await _context.Tarea.Where(t => t.PlanID == plid).OrderBy(t => t.FechaPlanificada).ToListAsync();
            ExamList = await _context.Examination.Where(exa => exa.EmpresaID == emid && exa.PlanID == plid).ToListAsync();
            // var ListaInspecciones = await _context.Examination.Where(ex=>ex.)
            // OneCheckList = await _context.Topico.Where(m=> m.IdList == MyCheckListId).OrderBy(m=>m.Correlative).ToListAsync();
            // TODO: Cambiar el formato de la fecha. mm/dd/yyyy HH:mm --> dd/mm/yyyy H24:mm
            /*
            NewTarea = new Tarea
            {
                EstadoID = 0,
                NombreTarea = "",
                PlanID = MyPlan.PlanID,
                EmpresaID=MyEmpresa.EmpresaID
            };
            */
            //PlanTareas = await _context.Tarea.Where(m=> m.PlanID == id).ToListAsync();
            if (MyPlan == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostExam()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await _context.SaveChangesAsync();
            return RedirectToPage("./Details", new { emid = NewTarea.EmpresaID, plid = NewTarea.PlanID });
        }

        /// <summary>
        /// Crear nueva tarea para el plan
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            NewTarea.EstadoID = 0;
            NewTarea.FechaFinPlanificada = NewTarea.FechaPlanificada.Date;
            await _context.SaveChangesAsync();
            //NewTarea.Checklist = await _context.Test.FindAsync(NewTarea.TestID);
            //            NewTarea.FechaEjecucionReal = null;
            // NewTarea.PlanID = Plan.PlanID;
            var plan = await _context.Plan.Include(pl => pl.ListaTareas).Where(pl=>pl.PlanID==NewTarea.PlanID).FirstOrDefaultAsync();
            plan.ListaTareas.AddTarea(NewTarea);
            await _context.SaveChangesAsync();
            // _context.Tarea.Add(NewTarea);
            // TODO: evitar que se carguen registros duplicados sin cambio de estado
            // await _context.SaveChangesAsync();
            var historicoTarea = new HistoricoTarea(NewTarea);
            _context.HistoricoTarea.Add(historicoTarea);

            await _context.SaveChangesAsync();
            ListaTareas = await _context.Tarea.Where(t => t.PlanID == NewTarea.PlanID).OrderBy(t => t.FechaPlanificada).ToListAsync();


            // return RedirectToPage("./Details");
            // return await OnGetAsync(MyEmpresa.EmpresaID, Plan.PlanID);
            return RedirectToPage("./Details", new { emid = NewTarea.EmpresaID, plid = NewTarea.PlanID });
        }
        public async Task<IActionResult> OnPostInitActivAsync(int? emid, int? plid, int? taid)
        {
            var emp = await _context.Empresa.FindAsync(emid);
            var plan = await _context.Plan.FindAsync(plid);
            var tarea = await _context.Tarea.FindAsync(taid);
            Examination ex = new Examination(tarea);
            /*
            Examination ex = new Examination
            {
                EmpresaID = emid ?? 0,
                FaenaID = 0,
                PersonaID1 = 1,
                PersonaID2 = 1//,
                //Prueba = tarea.Checklist
            };*/
            return RedirectToPage("./Details", new { emid = MyEmpresa.EmpresaID, plid = NewTarea.PlanID });
        }
    }
}
