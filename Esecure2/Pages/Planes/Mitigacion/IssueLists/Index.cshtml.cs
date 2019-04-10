using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.Issues;
using EsecureModel.Planificacion;
using EsecureModel.Faena;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Usuario;

namespace EsecureWebApp.Pages.Planes.Mitigacion.IssueLists
{
    [BindProperties]
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

        public IList<IssueList> IssueList { get;set; }
        
        public Plan MyPlan { get; set; }

        public Empresa MyEmpresa { get; set; }


        /*
        public async Task OnGetAsync()
        {
            IssueList = await _context.IssueList.ToListAsync();
        }*/
        public async Task OnGetAsync(int? emid, int? plid )
        {
            if(emid==null)
            {
                // MyEmpresa = await _context.Empresa.FirstOrDefaultAsync();
                IssueList = await _context.IssueList.ToListAsync();
                //MyPlan = 0;
                //MyPlan = await _context.Plan.FirstOrDefaultAsync(p => p.PlanID == plid);
            }
            else
            {
                MyEmpresa = await _context.Empresa.FirstOrDefaultAsync(m => m.EmpresaID == emid);
                IssueList = await _context.IssueList.Where(il => il.PlanID == plid).ToListAsync();
                MyPlan = await _context.Plan.FirstOrDefaultAsync(p => p.PlanID == plid);
            }
        }
    }
}
