using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EsecureWebApp.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EsecureModel.Usuario;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Esecure2.Data;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Faena;

namespace EsecureWebApp.Pages.Users.Adimistrators.Users
{
    public class IndexModel : BaseCodeModel
    {

        // private readonly Esecure2.Data.ApplicationDbContext _context;
        

        public IndexModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
        }
        // public Empresa MyEmpresa { get; set; }
        public IList<ApplicationUser> ApplicationUsers { get; set; }

        public async Task OnGetAsync(int emid)
        {
            MyEmpresa = await _context.Empresa.FindAsync(emid);
            ApplicationUsers = await _context.ApplicationUser.ToListAsync();
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                //return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var userName = await _userManager.GetUserNameAsync(user);
            var email = await _userManager.GetEmailAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            //Username = userName;

            //Input = new InputModel
            //{
            //    Email = email,
            //    PhoneNumber = phoneNumber
            //};

            //IsEmailConfirmed = await _userManager.IsEmailConfirmedAsync(user);
            ///**********************************************************/
            //// var user = await _userManager.GetUserAsync(User);
            //// IList<string> x = (IList<string>) _userManager.GetRolesAsync(user);
            //// UserRoles = (IList<string>) _userManager.GetRolesAsync(user);
            ////UserRoless = _userManager.GetRolesAsync(user).ToAsyncEnumerable();
            //listaRoles = await _roleManager.Roles.ToListAsync();
            //var ApplicationUserProfile = await _context.ApplicationUserProfile.ToListAsync();
            //var IdentityRole = await _context.IdentityRole.ToListAsync();
            //var ApplicationProfileRole = await _context.ApplicationProfileRole.ToListAsync();
            //var ApplicationProfile = await _context.ApplicationProfile.ToListAsync();
            /**********************************************************/

            //return Page();
        }
    }
}