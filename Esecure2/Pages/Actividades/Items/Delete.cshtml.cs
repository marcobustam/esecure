﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.Verificaciones;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Usuario;

namespace EsecureWebApp.Pages.Actividades.Items
{
    public class DeleteModel : BaseCodeModel
    {
        private readonly Esecure2.Data.ApplicationDbContext _context;

        public DeleteModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
        }

        [BindProperty]
        public ItemVerificacion ItemVerificacion { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ItemVerificacion = await _context.ItemVerificacion.FirstOrDefaultAsync(m => m.ItemVerificacionID == id);

            if (ItemVerificacion == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ItemVerificacion = await _context.ItemVerificacion.FindAsync(id);

            if (ItemVerificacion != null)
            {
                _context.ItemVerificacion.Remove(ItemVerificacion);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}