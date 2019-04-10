using System;
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

namespace EsecureWebApp.Pages.Actividades.Verificaciones
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
        [BindProperty]
        public ActividadVerificacion ActividadVerificacion { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ActividadVerificacion = await _context.ActividadVerificacion.FirstOrDefaultAsync(m => m.ActividadVerificacionID == id);
            ItemVerificacion = await _context.ItemVerificacion.Where(i => i.ActividadVerificacionID ==id).ToListAsync();
            EsteItemVerificacion = new ItemVerificacion();
            EsteItemVerificacion.ActividadVerificacionID =(int) id;
            if (ActividadVerificacion == null)
            {
                return NotFound();
            }
            return Page();
        }
        [BindProperty]
        public ItemVerificacion EsteItemVerificacion { get; set; }

        public IList<ItemVerificacion> ItemVerificacion { get; set; }

     

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            // EsteItemVerificacion.ActividadVerificacionID = ActividadVerificacion.ActividadVerificacionID;
            _context.ItemVerificacion.Add(EsteItemVerificacion);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
