using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Esecure2.Data;
using EsecureModel.Issues;
using EsecureModel.Planificacion;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Usuario;

namespace EsecureWebApp.Pages.Planes.Mitigacion.IssueLists
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

        public IActionResult OnGet(int? emid, int? plid, int? ilid)
        {
            if(plid == null)
            {
                return NotFound();
            }
            MyPlan = _context.Plan.Where(p => p.PlanID == plid).FirstOrDefault();
            if(!_context.IssueList.Where(p=>p.PlanID== plid).Any())
            {
                EsteIssueList = new IssueList
                {
                    PlanID = (int)plid,
                    Nombre = "Plan de Acción -" + MyPlan.NombrePlan,
                    ListaIssues = new List<IssueItem>()
                };
                MyPlan.ListaDeIssues = EsteIssueList;
            }


            return Page();
        }

        [BindProperty]
        public IssueList EsteIssueList { get; set; }
        public Plan MyPlan { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.IssueList.Add(EsteIssueList);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index", new { emid=MyPlan.EmpresaID, plid = MyPlan.PlanID });
        }
    }
}