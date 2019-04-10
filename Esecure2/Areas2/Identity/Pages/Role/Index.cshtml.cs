using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Esecure2.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EsecureWebApp.Areas.Identity.Pages.Role
{

    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public IndexModel(ApplicationDbContext context )
        {
            _context = context;
        }
        // public IList<> ListaRoles { get; set; }
        public void OnGet()
        {
            _context.Roles.ToList();

        }
    }
}