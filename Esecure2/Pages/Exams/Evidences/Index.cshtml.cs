using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.Exam;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Usuario;
using EsecureModel.Faena;
using EsecureModel.Planificacion;

namespace EsecureWebApp.Pages.Exams.Evidences
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

        public IList<Evidence> EvidenceList { get; private set; }

        public Empresa MyEmpresa { get; private set; }
        public Plan MyPlan { get; private set; }
        public Tarea MyTarea { get; private set; }
        public Examination MyExamination { get; private set; }
        public Response MyResponse { get; private set; }

        public async Task OnGetAsync(int emid, int plid, int taid, int exid, int reid)
        {
            try
            {
                EvidenceList = await _context.Evidence.Where(ev => ev.ResponseID == reid) .Include(e => e.FileUp).ToListAsync();
                //                    .Where(ev => ev.re == ).Include(e => e.FileUp).ToListAsync();
                MyEmpresa = await _context.Empresa.Where(em => em.EmpresaID == emid).FirstAsync();
                MyPlan = await _context.Plan.Where(pl => pl.PlanID == plid).FirstAsync();
                MyTarea = await _context.Tarea.Where(ta => ta.TareaID == taid).FirstAsync();
                MyExamination = await _context.Examination.Where(ex => ex.ExaminationID == exid).FirstAsync();
                MyResponse = await _context.Response.Where(re => re.ResponseID == reid).FirstAsync();
                /***********************************************************************************************/
            }
            catch
            {

            }
            finally
            {

            }
        }
    }
}
