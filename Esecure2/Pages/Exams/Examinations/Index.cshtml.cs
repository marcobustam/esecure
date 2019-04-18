using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.Exam;
using EsecureModel.Faena;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Usuario;

namespace EsecureWebApp.Pages.Exams.Examinations
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

        public IList<Examination> ExaminationList { get;set; }
        // public Empresa MyEmpresa { get; set; }
        public async Task OnGetAsync(int? emid, int? plid, int? taid, int? exid)
        {
            ExaminationList = await _context.Examination
                .Include(e => e.Prueba).ToListAsync();
            if(emid != null)
            {
                MyEmpresa = await _context.Empresa.FirstOrDefaultAsync(e => e.EmpresaID == emid);
                ExaminationList = ExaminationList.Where(ex => ex.EmpresaID == emid).ToList();
            }
            if(plid!=null)
            {
                ExaminationList = ExaminationList.Where(ex => ex.PlanID == plid).ToList();
            }
            if (taid!=null)
            {
                ExaminationList = ExaminationList.Where(ex => ex.TareaID == taid).ToList();
            }
            if (taid!=null)
            {
                ExaminationList = ExaminationList.Where(ex => ex.TareaID == taid).ToList();
            }

        }
    }
}
