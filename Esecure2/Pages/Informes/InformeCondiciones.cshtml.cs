using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Esecure2.Data;
using EsecureModel.ChartData;
using EsecureModel.Usuario;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace EsecureWebApp.Pages.Informes
{
    public class InformeCondicionesModel : BaseCodeModel
    {
        private readonly ApplicationDbContext _context;
        public InformeCondicionesModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
        }
        // InformeCondicionesModel() { }
        public ChartSerie chartSerie { get; set; }
        public IList<ChartSerie> chartSerieList { get; set; }
        
        public int cua1=0, cua2=1, cua3=2, cua4 = 3;
        public void OnGet()
        {
            Message = "Hola!";
            // chartSerie = new ChartSerie();
            chartSerieList = new List<ChartSerie>();
            for (int i =0;i<12;i++)
            {
                chartSerieList.Add(new ChartSerie(i));
            }
            PopulatePersonasDropDownList(_context);
            PopulateEmpresasDropDownList(_context);
            PopulateActividadVerificacionDropDownList(_context);
            PopulateCheckListTestDropDownList(_context);
            PopulateFaenasDropDownList(_context);

            /*
            *         public SelectList PersonasNameSL { get; set; }
            *         public SelectList EmpresasNameSL { get; set; }
            *         public SelectList ActividadVerificacionNameSL { get; set; }
            *         public SelectList CheckListSL { get; set; }
            *         public SelectList FaenasSL { get; set; }
            */
        }
    }
}