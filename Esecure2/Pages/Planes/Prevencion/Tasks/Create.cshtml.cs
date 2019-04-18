using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Esecure2.Data;
using EsecureModel.Planificacion;
using Microsoft.EntityFrameworkCore;
using EsecureModel.Faena;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Usuario;

namespace EsecureWebApp.Pages.Planes.Prevencion.Tasks
{
    public class CreateModel : BaseCodeModel
    {
        // private readonly Esecure2.Data.ApplicationDbContext _context;

        public CreateModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
        }
        public Plan MyPlan { get; set; }
        // public Empresa MyEmpresa { get; set; }
        public async Task<IActionResult> OnGetAsync(int? emid, int? plid)
        {
            if (plid == null)
            {
                return NotFound();
            }
            if (emid == null)
            {
                return NotFound();
            }
            // PopulateActividadVerificacionDropDownList(_context);
            PopulateCheckListTestDropDownList(_context);
            PopulateFaenasDropDownList(_context, (int)emid, null);
            MyEmpresa = await _context.Empresa.FirstOrDefaultAsync(m => m.EmpresaID == emid);
            MyPlan = await _context.Plan.Include(pl => pl.Persona).FirstOrDefaultAsync(m => m.PlanID == plid);
            return Page();
        }

        [BindProperty]
        public Tarea Tarea { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Tarea.Add(Tarea);
            await _context.SaveChangesAsync();

            // return RedirectToPage("./Index");
            return RedirectToPage("./Planes/Prevencion/Planificaciones/Details", new { emid = Tarea.EmpresaID, plid = Tarea.PlanID });
        }
    }
}