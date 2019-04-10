using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.Issues;
using EsecureModel.Faena;
using EsecureModel.Planificacion;
using Microsoft.Extensions.Configuration;
using EsecureModel.Usuario;
using Microsoft.AspNetCore.Identity;

namespace EsecureWebApp.Pages.Planes.Mitigacion.Issues
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

        public IList<IssueItem> ListaIssueItem { get;set; }
        public Empresa MyEmpresa { get; private set; }
        public List<IssueList> IssueList { get; private set; }
        public Plan MyPlan { get; private set; }

        public async Task OnGetAsync(int? emid, int? plid, int? ilid)
        {
            if(emid!=null)
            {
                if(plid!=null)
                {
                    if(ilid!=null)
                    {
                        ListaIssueItem = await _context.IssueItem.Where(li => li.IssueListId == ilid).ToListAsync();
                        MyEmpresa = await _context.Empresa.FirstOrDefaultAsync(m => m.EmpresaID == emid);
                        IssueList = await _context.IssueList.Where(il => il.PlanID == plid).ToListAsync();
                        MyPlan = await _context.Plan.FirstOrDefaultAsync(p => p.PlanID == plid);
                    }
                }
            }
            else
            {
                IssueList = await _context.IssueList.Where(il => il.PlanID == plid).ToListAsync();
            }
            
        }
    }
}
