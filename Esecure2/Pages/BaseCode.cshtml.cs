using Esecure2.Data;
using EsecureModel.Faena;
using EsecureModel.Soporte;
using EsecureModel.Usuario;
using EsecureWebApp.Mailers;
using EsecureWebApp.Pages.Mantenedores.Var;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
namespace EsecureWebApp.Pages
{
    [Authorize]
    public class BaseCodeModel : SelectListsPageModel
    {
        public string Message { get; set; }
        public Ticket ticket { get; set; }

        protected ApplicationDbContext _context { get; set; }
        public ApplicationUser AppUser { get; set; }
        public SignInManager<ApplicationUser> _signInManager { get; set; }
        public UserManager<ApplicationUser> _userManager { get; set; }
        public RoleManager<IdentityRole> _roleManager { get; set; }
        // private readonly Esecure2.Data.ApplicationDbContext _context;
        public IConfiguration _configuration { get; set; }
        public EmailHelper EmailHelper;

        public Empresa MyEmpresa { get; set; }


        public BaseCodeModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;            
            _context = context;
            // EmailHelper = new EmailHelper(_configuration, context);
            EmailHelper = new EmailHelper(context);
        }
        //public async Task<bool> CheckEnvAsync(int? emid)
        //{
        //    MyEmpresa = await _context.Empresa.FirstOrDefaultAsync(m => m.EmpresaID == emid);
        //    if (MyEmpresa == null)
        //    {
        //        RedirectToPage("/Error", new { message = "No está autorizado a ver esta información (Configurar empresa)." });
        //    }
        //    AppUser = await _userManager.GetUserAsync(User);
        //    if (AppUser.EmpresaID != emid)
        //    {
        //        RedirectToPage("/Error", new { message = "No está autorizado a ver esta información (Empresa no corresponde)." });
        //    }
        //    return true;
        //}
        public async Task<string> CheckEnvAsync(int? emid)
        {
            var rtmsg = "";
            MyEmpresa = await _context.Empresa.FirstOrDefaultAsync(m => m.EmpresaID == emid);
            
            AppUser = await _userManager.GetUserAsync(User);
            if(MyEmpresa==null)
            {
                MyEmpresa = await _context.Empresa.FirstOrDefaultAsync(m => m.EmpresaID == AppUser.EmpresaID);
            }
            if (AppUser.EmpresaID != emid && MyEmpresa == null)
            {
                rtmsg = "No está autorizado a ver esta información (Empresa no corresponde)." ;

            }
            else
            {
                MyEmpresa = await _context.Empresa.FirstOrDefaultAsync(m => m.EmpresaID == AppUser.EmpresaID);
                if (MyEmpresa == null)
                {
                    rtmsg = "No está autorizado a ver esta información (Configurar empresa).";
                }
            }
            rtmsg = "";

            return rtmsg;
        }

    }
}