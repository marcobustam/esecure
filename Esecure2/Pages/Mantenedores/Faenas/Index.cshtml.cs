﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.Faena;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Usuario;

namespace EsecureWebApp.Pages.Mantenedores.Faenas
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

        public IList<Faena> ListaFaena { get;set; }
        public Empresa MyEmpresa { get; set; }
        public async Task<ActionResult> OnGetAsync(int? emid)
        {
            if (emid == null)
            {
                return RedirectToPage("/Error", new { errorMsg = "No se ha suministrado el código de empresa." });
            }
            MyEmpresa = await _context.Empresa.FindAsync(emid);
            ListaFaena = await _context.Faena.Where(fa=>fa.EmpresaID==emid).ToListAsync();
            return Page();
        }
    }
}