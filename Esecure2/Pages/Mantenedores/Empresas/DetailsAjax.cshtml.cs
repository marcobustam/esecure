using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Esecure2.Data;
using EsecureModel.Faena;
using EsecureModel.Personal;
using EsecureModel.Planificacion;
using EsecureModel.Issues;
using EsecureWebApp.Pages.Mantenedores.Var;
using EsecureModel.Location;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Configuration;
using EsecureModel.Usuario;
using Microsoft.AspNetCore.Identity;

namespace EsecureWebApp.Pages.Mantenedores.Empresas
{
    public class DetailsAjaxModel : BaseCodeModel
    {
        private readonly Esecure2.Data.ApplicationDbContext _context;
        public static int counterStrike { get; private set; }
        public DetailsAjaxModel(IConfiguration configuration, ApplicationDbContext context, SignInManager<ApplicationUser> SignInManager, UserManager<ApplicationUser> UserManager, RoleManager<IdentityRole> RoleManager) : base(configuration, context, SignInManager, UserManager, RoleManager)
        {
            _configuration = configuration;
            _signInManager = SignInManager;
            _userManager = UserManager;
            _context = context;
        }
        public IActionResult OnGetList(int? emid , string tipo)
        {
            PlanList = _context.Plan.Where(p => p.EmpresaID == emid).ToList();
            Empresa = _context.Empresa.FirstOrDefault(m => m.EmpresaID == emid);
            MyEmpresa = Empresa;
            PlanList = _context.Plan.Where(p => p.EmpresaID == emid).ToList();
            Representante = _context.Persona.FirstOrDefault(r => r.PersonaID == Empresa.PersonaID);
            ListaPersona = _context.Persona.ToList();
            IssueList = _context.IssueList.Where(il => il.EmpresaID == emid).ToList();
            ListaFaenas = _context.Faena.Where(fa => fa.EmpresaID == emid).ToList();
            PopulatePersonasDropDownList(_context);
            PopulateEmpresasDropDownList(_context);
            ListaResponsables = _context.Persona.ToList();

            IActionResult result;

            if (tipo == "p")
            {
                result = new PartialViewResult() { ViewName = "_ListPlanesAjax", ViewData = this.ViewData };
            }
            else if (tipo == "f")
            {
                result = new PartialViewResult() { ViewName = "_ListFaenaAjax", ViewData = this.ViewData };
            }
            else if (tipo == "h")
            {
                result = new PartialViewResult() { ViewName = "_ListPersonaAjax", ViewData = this.ViewData };
            }
            else
            {
                result = new EmptyResult();
            }
            return result;
        }
        public  IActionResult OnGetLista(int? emid)
        {
            PlanList = _context.Plan.Where(p => p.EmpresaID == emid).ToList();
            Empresa =  _context.Empresa.FirstOrDefault(m => m.EmpresaID == emid);
            MyEmpresa = Empresa;
            PlanList = _context.Plan.Where(p => p.EmpresaID == emid).ToList();
            Representante = _context.Persona.FirstOrDefault(r => r.PersonaID == Empresa.PersonaID);
            ListaPersona = _context.Persona.ToList();
            IssueList = _context.IssueList.Where(il => il.EmpresaID == emid).ToList();
            ListaFaenas = _context.Faena.Where(fa => fa.EmpresaID == emid).ToList();
            PopulatePersonasDropDownList(_context);
            PopulateEmpresasDropDownList(_context);
            ListaResponsables = _context.Persona.ToList();
            var result = new PartialViewResult() { ViewName = "_ListPlanesAjax", ViewData = this.ViewData };
            return result;
        }
        public Empresa Empresa { get; set; }
        public Persona Representante { get; set; }
        public IList<Plan> PlanList { get; set; }
        public Empresa MyEmpresa { get; set; }
        public IList<Persona> ListaResponsables { get; set; }
        public IList<Persona> ListaPersona { get; set; }
        public IList<IssueList> IssueList { get; set; }
        public Plan NewPlan { get; set; }
        public IList<Faena> ListaFaenas { get; set; }
        [BindProperty]
        public Persona NewPersona { get; set; }

        public Direccion NewDireccion { get; set; }

        public async Task<IActionResult> OnGetAsync(int? emid)
        {
            /*
            PopulatePersonasDropDownList(_context);
            PopulateEmpresasDropDownList(_context);
            // TODO: Reorganizar código.
            if (emid == null)
            {
                Message = "No encontrado!";
                return NotFound();
            }
            Message = "No encontrado!";
            ListaPersona = await _context.Persona.ToListAsync();
            IssueList = await _context.IssueList.Where(il => il.EmpresaID == emid).ToListAsync();
            ListaFaenas = await _context.Faena.Where(fa=>fa.EmpresaID==emid).ToListAsync();
            // Muestra todos
            if (!(emid == null))
            {
                // TODO: Agregar estados y filtrar por estado.
                MyEmpresa = await _context.Empresa.FirstOrDefaultAsync(e => e.EmpresaID == emid);
                PlanList = await _context.Plan.Where(p => p.EmpresaID == emid).ToListAsync();
                ListaResponsables = await _context.Persona.ToListAsync();
                // ListaEmpresas = await _context.Empresa.ToListAsync();
            }
            else
            {
                MyEmpresa = new Empresa();
                PlanList = await _context.Plan.ToListAsync();
                ListaResponsables = await _context.Persona.ToListAsync();
                // ListaEmpresas = await _context.Empresa.ToListAsync();
            }
            */
            Empresa = await _context.Empresa.FirstOrDefaultAsync(m => m.EmpresaID == emid);
            Representante = await _context.Persona.FirstOrDefaultAsync(r => r.PersonaID == Empresa.PersonaID);
            if (Empresa == null)
            {
                return NotFound();
            }
            return Page();
        }
        [BindProperty]
        public Faena NuevaFaena { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //await _context.Faena.Add(NuevaFaena);
            await _context.SaveChangesAsync();
            
            return RedirectToPage("./Index");
        }
    }
}
