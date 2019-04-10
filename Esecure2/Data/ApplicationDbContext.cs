using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EsecureModel.Parametro;
using EsecureModel.Faena;
using EsecureModel.Personal;
using EsecureModel.Planificacion;
using EsecureModel.Verificaciones;
using EsecureModel.Issues;
using EsecureModel.Exam;
using EsecureModel.Location;
using EsecureModel.File;
using EsecureModel.Usuario;
using EsecureModel.Soporte;
using EsecureModel.Config;
using EsecureModel.Mailer;
using Microsoft.AspNetCore.Identity;
using EsecureModel.Bbs.Bussiness;
using bbs.Models.Params;

namespace Esecure2.Data
{
    //public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Estado> Estado { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Faena> Faena { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Plan> Plan { get; set; }
        public DbSet<Tarea> Tarea { get; set; }
        public DbSet<ActividadVerificacion> ActividadVerificacion { get; set; }
        public DbSet<ItemVerificacion> ItemVerificacion { get; set; }
        public DbSet<IssueList> IssueList { get; set; }
        public DbSet<IssueItem> IssueItem { get; set; }
        public DbSet<ListaDeTareas> ListaDeTareas { get; set; }
        public DbSet<HistoricoTarea> HistoricoTarea { get; set; }
        public DbSet<Test> Test { get; set; }
        public DbSet<Response> Response { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Examination> Examination { get; set; }
        public DbSet<ResponseType> ResponseType { get; set; }
        public DbSet<Direccion> Direccion { get; set; }
        public DbSet<FileUp> FileUp { get; set; }
        public DbSet<FileUpType> FileUpType { get; set; }
        public DbSet<FolderUp> FolderUp { get; set; }
        public DbSet<Evidence> Evidence { get; set; }
        public DbSet<EvidenceType> EvidenceType { get; set; }
        public DbSet<IdentityRole> IdentityRole { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<EsecureModel.Soporte.Ticket> Ticket { get; set; }
        public DbSet<EsecureModel.Planificacion.PlanPrevencion> PlanPrevencion { get; set; }
        public DbSet<EsecureModel.Config.WebConfiguration> WebConfiguration { get; set; }
        public DbSet<EsecureModel.Mailer.MailSender> MailSender { get; set; }
    }
    public class BbsContext : DbContext
    {
        public BbsContext(DbContextOptions<BbsContext> options)
            : base(options)
        {
        }

        public DbSet<Gender> Gender { get; set; }

        public DbSet<ObsCategory> ObsCategory { get; set; }

        public DbSet<Configuration> Configuration { get; set; }

        public DbSet<Division> Division { get; set; }

        public DbSet<ObsItem> ObsItem { get; set; }

        public DbSet<Person> Person { get; set; }

        public DbSet<RespType> RespType { get; set; }

        public DbSet<WorkSite> WorkSite { get; set; }

        public DbSet<Site> Site { get; set; }

        public DbSet<Inspection> Inspection { get; set; }

        public DbSet<WebConfiguration> WebConfiguration { get; set; }
    }
}
