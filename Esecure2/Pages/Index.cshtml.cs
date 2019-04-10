using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Esecure2.Data;
using EsecureModel.Faena;
using EsecureModel.Usuario;
using EsecureWebApp.Mailers;
using EsecureWebApp.Pages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Esecure2.Pages
{
    //[Authorize]
    public class IndexModel : BaseCodeModel
    {
        
        public string ErrorMessage { get; set; }
        // public Empresa MyEmpresa { get; set; }

        //private readonly ApplicationDbContext _context;
        public IndexModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
        }
        
        public async Task<PageResult> OnGetAsync(int? emid )
        {
            var message = "";
            try
            {
                message = await CheckEnvAsync(emid);
                if (string.IsNullOrEmpty(message))
                {
                    Message = "";
                    return Page();
                }
                else
                {
                    RedirectToPage("/Error", new { message = "Error al checkear configuración de usuario." + message });
                }
                //if ((exid == null) && (taid == null))
                //{
                //    return NotFound();
                //}
                // Message = AppUser.GetUserFullName();
                //if (!(errorMsg == null))
                //{

                //    if (errorMsg.Length > 0)
                //    {
                //        Message = errorMsg;
                //    }
                //    else
                //    {
                //        Message = null;
                //    }
                //}
            }
            catch(NullReferenceException n)
            {
                Message = "User is null";
                message = Message;

            }
            catch (Exception e)
            {
                message = Message;
            }
            finally
            {
                RedirectToPage("/Error", new { message = "Error al checkear configuración de usuario." + message });
            }
            return Page();

        }
    }
}
           