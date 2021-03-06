﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Esecure2.Data;
using EsecureModel.Parametro;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Usuario;

namespace EsecureWebApp.Pages.Mantenedores.Estados
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

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Estado Estado { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Estado.Add(Estado);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}