﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using EsecureWebApp.Pages;
using EsecureModel.Usuario;
using Microsoft.Extensions.Configuration;
using Esecure2.Data;

namespace EsecureWebApp.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginModel : BaseCodeModel
    {
        // private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;

        public LoginModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager, ILogger<LoginModel> logger) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
            _logger = logger;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Usuario (email)")]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Recordar?")]
            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            // returnUrl = returnUrl ?? Url.Content("~/Index");
            returnUrl = Url.Content("/Index");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            // returnUrl = returnUrl ?? Url.Content("~/Index");
            returnUrl = Url.Content("/Index");

            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                //var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: true);

                ApplicationUser signedUser = await _userManager.FindByEmailAsync(Input.Email);
                var result = await _signInManager.PasswordSignInAsync(signedUser.UserName, Input.Password, Input.RememberMe, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User logged in.");
                    // returnUrl = returnUrl + "?emid=" + AppUser.EmpresaID;
                    // signedUser = await _userManager.GetUserAsync(User);
                    //if ( User.Identity.IsAuthenticated)
                    //{
                    if(signedUser.EmpresaID != 0)
                    {
                        return LocalRedirect(returnUrl + "?emid=" + signedUser.EmpresaID);
                    }
                    else
                    {
                        returnUrl = "/Error?errorMsg=No tienes configurada tu empresa, comunícate con tu administrador";
                        return LocalRedirect(returnUrl);
                    }
                    //}
                    
                }
                else if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                }
                else if (result.IsLockedOut)
                {
                    _logger.LogWarning("User account locked out.");
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    // + result. + result.ToString()
                    ModelState.AddModelError(string.Empty, "Intento no válido.");
                    return Page();
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}