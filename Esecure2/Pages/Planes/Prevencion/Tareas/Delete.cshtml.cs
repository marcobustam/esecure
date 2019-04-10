using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.Planificacion;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Usuario;

namespace EsecureWebApp.Pages.Planes.Prevencion.Tareas
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
        public Tarea Tarea { get; set; }

        public async Task<IActionResult> OnGetAsync(int? taid)
        {
            if (taid == null)
            {
                return NotFound();
            }

            Tarea = await _context.Tarea.FirstOrDefaultAsync(m => m.TareaID == taid);

            if (Tarea == null)
            {
                return NotFound();
            }
            return Page();
        }
        public Tarea EstaTarea { get; set; }
        [BindProperty]
        public HistoricoTarea NuevoHistoricoTarea { get; set; }
        public async Task<IActionResult> OnPostAsync(int? taid)
        {
            if (taid == null)
            {
                return NotFound();
            }

            Tarea = await _context.Tarea.FindAsync(taid);

            if (Tarea != null)
            {
                // sólo cambia estado.
                // _context.Tarea.Remove(Tarea);
                _context.Tarea.Find(taid).EstadoID = EstadoTarea.Cancelada;
                EstaTarea = await _context.Tarea.FirstOrDefaultAsync(ta => ta.TareaID == NuevoHistoricoTarea.TareaID);
                _context.HistoricoTarea.Add(NuevoHistoricoTarea);
                EstaTarea.EstadoID = NuevoHistoricoTarea.NuevoEstado;
                //await _context.SaveChangesAsync();
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("/Planes/Prevencion/Planificaciones/Details", new { emid = Tarea.EmpresaID, plid = Tarea.PlanID });
        }
    }
}
