using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.Planificacion;
using EsecureModel.Faena;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Usuario;

namespace EsecureWebApp.Pages.Planes.Prevencion.Planificaciones
{
    public class EditModel : BaseCodeModel
    {
        private readonly Esecure2.Data.ApplicationDbContext _context;

        public EditModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
        }

        [BindProperty]
        public Plan EstePlan { get; set; }
        public Empresa MyEmpresa { get; set; }
        public async Task<IActionResult> OnGetAsync(int? emid, int? plid)
        {
            if (plid == null || emid == null)
            {
                return NotFound();
            }

            // EstePlan = await _context.Plan.Include(ep=>ep.ListaTareas).Include(es=>es.Persona )FirstOrDefaultAsync(m => m.PlanID == plid);
            // EstePlan = await _context.Plan.Include(ep=>ep.ListaTareas).Include(es=>es.Persona).FirstOrDefaultAsync(m => m.PlanID == plid);
            EstePlan = await _context.Plan.FirstOrDefaultAsync(m => m.PlanID == plid);
            MyEmpresa = await _context.Empresa.FirstOrDefaultAsync(m => m.EmpresaID == emid);
            PopulatePersonasDropDownList(_context, (int) emid, null);
            if (EstePlan == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(EstePlan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlanExists(EstePlan.PlanID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            catch (Exception ex)
            {
                RedirectToPage("/Index", new { errorMsg = ex.Message });
            }

            return RedirectToPage("./Index", new { emid = EstePlan.EmpresaID } );
        }

        private bool PlanExists(int id)
        {
            return _context.Plan.Any(e => e.PlanID == id);
        }
    }
}
