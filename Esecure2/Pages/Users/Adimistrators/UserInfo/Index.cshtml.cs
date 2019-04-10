using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EsecureModel.Usuario;
using Esecure2.Data;
using Microsoft.Extensions.Configuration;

namespace EsecureWebApp.Pages.Users.Adimistrators.UserInfo
{
    public class IndexModel : BaseCodeModel
    {
        //private readonly UserManager<ApplicationUser> _userManager;
        //private readonly SignInManager<ApplicationUser> _signInManager;
        //private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailSender _emailSender;
        //private readonly ApplicationDbContext _context;

        public IndexModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
        }

        public string Username { get; set; }

        public bool IsEmailConfirmed { get; set; }
        public IList<string> UserRoles { get; set; }
        public IAsyncEnumerable<IList<string>> UserRoless { get; set; }
        public List<IdentityRole> listaRoles { get; private set; }
        [TempData]
        public string StatusMessage { get; set; }
        [BindProperty]
        public string rolexchage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var userName = await _userManager.GetUserNameAsync(user);
            var email = await _userManager.GetEmailAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            Username = userName;

            Input = new InputModel
            {
                Email = email,
                PhoneNumber = phoneNumber
            };

            IsEmailConfirmed = await _userManager.IsEmailConfirmedAsync(user);
            /**********************************************************/
            // var user = await _userManager.GetUserAsync(User);
            // IList<string> x = (IList<string>) _userManager.GetRolesAsync(user);
            // UserRoles = (IList<string>) _userManager.GetRolesAsync(user);
            //UserRoless = _userManager.GetRolesAsync(user).ToAsyncEnumerable();
            listaRoles = await _roleManager.Roles.ToListAsync();
            //var ApplicationUserProfile = await _context.ApplicationUserProfile.ToListAsync();
            //var IdentityRole = await _context.IdentityRole.ToListAsync();
            //var ApplicationProfileRole = await _context.ApplicationProfileRole.ToListAsync();
            //var ApplicationProfile = await _context.ApplicationProfile.ToListAsync();
            /**********************************************************/

            return Page();
        }
        public async Task<IActionResult> OnGetAsync(string otherUserId)
        {
            var otherUser = await _userManager.FindByIdAsync(otherUserId);
            ApplicationUser user;
            if(otherUser!= null)
            {
                user = otherUser;
            }
            else
            {
                user = await _userManager.GetUserAsync(User);
            }
            
            if (user == null)
            {
                //return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
                return RedirectToPage("./Index");
            }

            var userName = await _userManager.GetUserNameAsync(user);
            var email = await _userManager.GetEmailAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            Username = userName;

            Input = new InputModel
            {
                Email = email,
                PhoneNumber = phoneNumber
            };

            IsEmailConfirmed = await _userManager.IsEmailConfirmedAsync(user);
            /**********************************************************/
            // var user = await _userManager.GetUserAsync(User);
            // IList<string> x = (IList<string>) _userManager.GetRolesAsync(user);
            // UserRoles = (IList<string>) _userManager.GetRolesAsync(user);
            //UserRoless = _userManager.GetRolesAsync(user).ToAsyncEnumerable();
            listaRoles = await _roleManager.Roles.ToListAsync();
            //var ApplicationUserProfile = await _context.ApplicationUserProfile.ToListAsync();
            //var IdentityRole = await _context.IdentityRole.ToListAsync();
            //var ApplicationProfileRole = await _context.ApplicationProfileRole.ToListAsync();
            //var ApplicationProfile = await _context.ApplicationProfile.ToListAsync();
            /**********************************************************/

            return Page();
        }
        public void OnPostOn()
        {
            var a = 0;
            a++;

        }
        public void OnPostOff()
        {
            var b = 0;
            b++;

        }
        public async Task<IActionResult> OnPostAsyncOn()
        {
            var user = await _userManager.GetUserAsync(User);
            var result = await _userManager.AddToRoleAsync(user, rolexchage);
            await _signInManager.RefreshSignInAsync(user);
            await _context.SaveChangesAsync();
            return RedirectToPage();
        }
        public async Task<IActionResult> OnPostAsyncOff()
        {
            var user = await _userManager.GetUserAsync(User);
            var result = await _userManager.RemoveFromRoleAsync(user, rolexchage);
            await _signInManager.RefreshSignInAsync(user);
            await _context.SaveChangesAsync();
            return RedirectToPage();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            /*
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var email = await _userManager.GetEmailAsync(user);
            if (Input.Email != email)
            {
                var setEmailResult = await _userManager.SetEmailAsync(user, Input.Email);
                if (!setEmailResult.Succeeded)
                {
                    var userId = await _userManager.GetUserIdAsync(user);
                    throw new InvalidOperationException($"Unexpected error occurred setting email for user with ID '{userId}'.");
                }
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    var userId = await _userManager.GetUserIdAsync(user);
                    throw new InvalidOperationException($"Unexpected error occurred setting phone number for user with ID '{userId}'.");
                }
            }

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            */
            var user = await _userManager.GetUserAsync(User);
            var userRoles = _userManager.GetRolesAsync(user);
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostSendVerificationEmailAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }


            var userId = await _userManager.GetUserIdAsync(user);
            var email = await _userManager.GetEmailAsync(user);
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var callbackUrl = Url.Page(
                "/Account/ConfirmEmail",
                pageHandler: null,
                values: new { userId = userId, code = code },
                protocol: Request.Scheme);
            await _emailSender.SendEmailAsync(
                email,
                "Confirm your email",
                $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

            StatusMessage = "Verification email sent. Please check your email.";
            return RedirectToPage();
        }
    }
}