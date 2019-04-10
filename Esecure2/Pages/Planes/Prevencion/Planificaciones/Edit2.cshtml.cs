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
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Usuario;
using EsecureModel.Personal;
using EsecureModel.Issues;

namespace EsecureWebApp.Pages.Planes.Prevencion.Planificaciones
{
    public class Edit2Model : BaseCodeModel
    {
        // private readonly Esecure2.Data.ApplicationDbContext _context;

        public Edit2Model(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
        }

        [BindProperty]
        public Plan PlanPrevencion { get; set; }
        [BindProperty]
        public Persona MyPersona { get; private set; }
        [BindProperty]
        public ListaDeTareas MyListaDeTareas { get; private set; }
        [BindProperty]
        public IssueList MyListaDeIssues { get; private set; }

        public async Task<IActionResult> OnGetAsync(int? emid,int? plid)
        {
            MyEmpresa = await _context.Empresa.FirstOrDefaultAsync(m => m.EmpresaID == emid);
            if (plid == null)
            {
                return NotFound();
            }

            // var PlanesPrevencion = await _context.Plan.ToListAsync();
            PlanPrevencion = await _context.Plan
                .Include(p => p.Empresa)
                .Include(p => p.Persona)
                .Include(p => p.ListaTareas)
                .Include(p => p.ListaDeIssues)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.PlanID == plid);
            MyPersona = PlanPrevencion.Persona;
            MyListaDeTareas = PlanPrevencion.ListaTareas;
            MyListaDeIssues = PlanPrevencion.ListaDeIssues;
            if (PlanPrevencion == null)
            {
                return NotFound();
            }
           ViewData["EmpresaID"] = new SelectList(_context.Empresa, "EmpresaID", "EmpresaID");
           ViewData["PersonaID"] = new SelectList(_context.Persona, "PersonaID", "PersonaID");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            MyEmpresa = await _context.Empresa.FirstOrDefaultAsync(m => m.EmpresaID == PlanPrevencion.EmpresaID);

            var PlanPrev = await _context.Plan
                .Include(p => p.Empresa)
                .Include(p => p.Persona)
                .Include(p => p.ListaTareas)
                .Include(p => p.ListaDeIssues)
                .FirstOrDefaultAsync(m => m.PlanID == PlanPrevencion.PlanID);
            PlanPrevencion.Empresa = PlanPrev.Empresa;
            
            if(PlanPrevencion.PersonaID == PlanPrev.PersonaID)
            {
                PlanPrevencion.Persona = PlanPrev.Persona;
            }
            else
            {
                PlanPrevencion.Persona = await _context.Persona.Where(pe => pe.PersonaID == PlanPrevencion.PersonaID).FirstAsync();
            }
            PlanPrevencion.ListaTareas = PlanPrev.ListaTareas;
            PlanPrevencion.ListaDeIssues = PlanPrev.ListaDeIssues;

            _context.Attach(PlanPrevencion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlanPrevencionExists(PlanPrevencion.PlanID))
                {
                    return NotFound();
                }
                else
                {
                    return RedirectToPage("./Error", new { enid = PlanPrevencion.EmpresaID });
                }
            }

            return RedirectToPage("./Index", new { enid = PlanPrevencion.EmpresaID });
        }

        private bool PlanPrevencionExists(int id)
        {
            return _context.PlanPrevencion.Any(e => e.PlanID == id);
        }
    }
}
