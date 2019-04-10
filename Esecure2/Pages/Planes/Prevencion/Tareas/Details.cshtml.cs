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
    public class DetailsModel : BaseCodeModel
    {
        private readonly Esecure2.Data.ApplicationDbContext _context;

        public DetailsModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
        }

        public Tarea EstaTarea { get; set; }
        [BindProperty]
        public HistoricoTarea NuevoHistoricoTarea { get; set; }

        public async Task<IActionResult> OnGetAsync(int? taid)
        {
            if (taid == null)
            {
                return NotFound();
            }

            EstaTarea = await _context.Tarea.FirstOrDefaultAsync(m => m.TareaID == taid);

            if (EstaTarea == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            // TODO: Revisar back de la página.
            if (!ModelState.IsValid)
            {
                return Page();
            }
            EstaTarea = await _context.Tarea.FirstOrDefaultAsync(ta => ta.TareaID == NuevoHistoricoTarea.TareaID);
            _context.HistoricoTarea.Add(NuevoHistoricoTarea);
            EstaTarea.EstadoID = NuevoHistoricoTarea.NuevoEstado;
            await _context.SaveChangesAsync();
            var tid = id;
            return RedirectToPage("./Details", "OnGetAsync", routeValues: new { taid = id });
            //return Page();
        }
    }
}
