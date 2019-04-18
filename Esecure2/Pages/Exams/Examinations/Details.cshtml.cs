using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.Exam;
using Microsoft.AspNetCore.Mvc.Rendering;
using EsecureModel.ChartData;
using EsecureModel.Faena;
using EsecureModel.Planificacion;
using Microsoft.Extensions.Configuration;
using EsecureModel.Usuario;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Personal;

namespace EsecureWebApp.Pages.Exams.Examinations
{
    public class DetailsModel : BaseCodeModel
    {
        

        public DetailsModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
        }
        [BindProperty]
        public Examination Examination { get; set; }
        [BindProperty]
        public Response ResponseItem { get; set; }
        public IList<Question> QuestionList { get; set; }
        public IList<Evidence> MyEvidenceList { get; set; }
        public SelectList ResponseTypeList { get; set; }
        public List<Category> CategoryList { get; set; }
        // public Empresa MyEmpresa { get; set; }
        public Plan MyPlan { get; set; }
        public Tarea MyTask { get; set; }
        public Persona Examinador { get; private set; }
        public Persona Examinado { get; private set; }

        /*
        public async Task<IActionResult> OnGetAsync(int? exid)
        {
            if (exid == null)
            {
                return NotFound();
            }
            ResponseItem = new Response();
            // Obtenemos el detalle de la Verificación
            Examination = await _context.Examination.Include(e => e.Prueba).Include(r=>r.ListaRespuestas).FirstOrDefaultAsync(m => m.ExaminationID == exid);
            var categorias = _context;
            // Obtenemos el listado de la prueba o CheckList que se aplicará
            chartSerieList = new List<ChartSerie>();
            for (int i = 0; i < 3; i++)
            {
                chartSerieList.Add(new ChartSerie());
            }
            QuestionList = await _context.Question.Where(q=>q.TestID== Examination.TestID).ToListAsync();
            // Examination.GetCategoryStatus(QuestionList);
            var sl = await _context.ResponseType.ToListAsync();
            ResponseTypeList = new SelectList(sl , "ResponseTypeID", "ResponseValue");
            CategoryList = await _context.Category.ToListAsync();
            if (Examination == null)
            {
                return NotFound();
            }
            Examination.TotalRespuestas = Examination.Prueba.QuestionList.Count();
            Examination.RespuestasCompletadas = Examination.ListaRespuestas.Count();
            return Page();
        } */
        private bool CreateExamination(Examination exam)
        {


            return true;
        }
        public async Task<IActionResult> OnGetAsync(int? emid ,int? plid ,int? taid ,int? exid)
        {
            try
            {
                AppUser = await _userManager.GetUserAsync(User);
                if(AppUser.EmpresaID!= emid)
                {
                    RedirectToPage("/Error", new { message = "No está autorizado a ver esta información." });
                }
                if ((exid == null) && (taid == null))
                {
                    return NotFound();
                }
                ResponseItem = new Response();
                // Obtenemos el detalle de la Verificación
                //OK-> Examination = await _context.Examination.Include(e => e.Prueba).Include(r=>r.ListaRespuestas).FirstOrDefaultAsync(m => m.ExaminationID == exid);
                Examination = await _context.Examination.Include(e => e.Prueba).Include(r => r.ListaRespuestas).ThenInclude(re => re.EvidenceList).FirstOrDefaultAsync(m => m.ExaminationID == exid);
                MyEmpresa = await _context.Empresa.FindAsync(Examination.EmpresaID);
                // MyEvidenceList = await _context.Evidence.ToListAsync();
                MyPlan = await _context.Plan.Include(mp => mp.Persona).Where(pl => pl.PlanID == Examination.PlanID).FirstOrDefaultAsync();
                MyTask = await _context.Tarea.Where(ta => ta.TareaID == Examination.TareaID).FirstAsync();
                Examinador = await _context.Persona.FindAsync(Examination.PersonaID1);
                Examinado = await _context.Persona.FindAsync(Examination.PersonaID2);

                var categorias = _context;
                // Obtenemos el listado de la prueba o CheckList que se aplicará
                ChartSerieList = new List<ChartSerie>();
                for (int i = 0; i < 3; i++)
                {
                    ChartSerieList.Add(new ChartSerie());
                }
                QuestionList = await _context.Question.Where(q => q.TestID == Examination.TestID).ToListAsync();
                // Examination.GetCategoryStatus(QuestionList);
                var sl = await _context.ResponseType.ToListAsync();
                ResponseTypeList = new SelectList(sl, "ResponseTypeID", "ResponseValue");
                CategoryList = await _context.Category.ToListAsync();
                if (Examination == null || MyEmpresa == null)
                {
                    return NotFound();
                }
                else
                {
                    if (Examination.Prueba != null)
                    {
                        if (Examination.Prueba.QuestionList != null)
                        {
                            Examination.TotalRespuestas = Examination.Prueba.QuestionList.Count;
                        }
                        else
                        {
                            Examination.TotalRespuestas = 0;
                        }
                        if (Examination.ListaRespuestas != null)
                        {
                            Examination.RespuestasCompletadas = Examination.ListaRespuestas.Count;
                        }
                        else
                        {
                            Examination.RespuestasCompletadas = 0;
                        }
                    }
                }
            }
            catch (Exception e)
            {

            }
            finally
            {

            }
            
            return Page();
        }
        /*
        public async Task<IActionResult> OnGetAsync(int? exid)
        {
            if (exid == null)
            {
                return NotFound();
            }
            ResponseItem = new Response();
            // Obtenemos el detalle de la Verificación
            Examination = await _context.Examination.Include(e => e.Prueba).Include(r=>r.ListaRespuestas).FirstOrDefaultAsync(m => m.ExaminationID == exid);
            var categorias = _context;
            // Obtenemos el listado de la prueba o CheckList que se aplicará
            chartSerieList = new List<ChartSerie>();
            for (int i = 0; i < 3; i++)
            {
                chartSerieList.Add(new ChartSerie());
            }
            QuestionList = await _context.Question.Where(q=>q.TestID== Examination.TestID).ToListAsync();
            // Examination.GetCategoryStatus(QuestionList);
            var sl = await _context.ResponseType.ToListAsync();
            ResponseTypeList = new SelectList(sl , "ResponseTypeID", "ResponseValue");
            CategoryList = await _context.Category.ToListAsync();
            if (Examination == null)
            {
                return NotFound();
            }
            Examination.TotalRespuestas = Examination.Prueba.QuestionList.Count();
            Examination.RespuestasCompletadas = Examination.ListaRespuestas.Count();
            return Page();
        } */
        public IList<ChartSerie> ChartSerieList { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            ResponseItem.TimeStamp = DateTime.Now;
            _context.Response.Add(ResponseItem);
            await _context.SaveChangesAsync();
            Examination = await _context.Examination
                .Include(e => e.Prueba).Include(r => r.ListaRespuestas).FirstOrDefaultAsync(m => m.ExaminationID == ResponseItem.ExaminationID);
            Examination.ListaRespuestas.Add(ResponseItem);
            await _context.SaveChangesAsync();
            return RedirectToPage("/Exams/Examinations/Details", new { exid = ResponseItem.ExaminationID } );
        }
    }
}
