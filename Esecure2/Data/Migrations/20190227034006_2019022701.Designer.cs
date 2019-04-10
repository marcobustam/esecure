﻿// <auto-generated />
using System;
using Esecure2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Esecure2.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190227034006_2019022701")]
    partial class _2019022701
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EsecureModel.Config.WebConfiguration", b =>
                {
                    b.Property<int>("WebConfigurationID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("WebConfigurationGroup");

                    b.Property<int>("WebConfigurationIndex");

                    b.Property<string>("WebConfigurationName");

                    b.Property<string>("WebConfigurationValue");

                    b.HasKey("WebConfigurationID");

                    b.ToTable("WebConfiguration");
                });

            modelBuilder.Entity("EsecureModel.Exam.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("EsecureModel.Exam.Evidence", b =>
                {
                    b.Property<int>("EvidenceID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion");

                    b.Property<int?>("EvidenceTypeID");

                    b.Property<int>("FileUpID");

                    b.Property<DateTime>("LastMod");

                    b.Property<int>("PersonaID");

                    b.Property<int>("ResponseID");

                    b.Property<DateTime>("TimeStamp");

                    b.HasKey("EvidenceID");

                    b.HasIndex("EvidenceTypeID");

                    b.HasIndex("FileUpID");

                    b.HasIndex("ResponseID");

                    b.ToTable("Evidence");
                });

            modelBuilder.Entity("EsecureModel.Exam.EvidenceType", b =>
                {
                    b.Property<int>("EvidenceTypeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EvidenceTypeName");

                    b.HasKey("EvidenceTypeID");

                    b.ToTable("EvidenceType");
                });

            modelBuilder.Entity("EsecureModel.Exam.Examination", b =>
                {
                    b.Property<int>("ExaminationID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmpresaID");

                    b.Property<int>("FaenaID");

                    b.Property<int>("PersonaID1");

                    b.Property<int>("PersonaID2");

                    b.Property<int>("PlanID");

                    b.Property<int>("RespuestasCompletadas");

                    b.Property<int>("TareaID");

                    b.Property<int?>("TestID");

                    b.Property<DateTime>("TimeStamp");

                    b.Property<int>("TotalRespuestas");

                    b.HasKey("ExaminationID");

                    b.HasIndex("TestID");

                    b.ToTable("Examination");
                });

            modelBuilder.Entity("EsecureModel.Exam.Question", b =>
                {
                    b.Property<int>("QuestionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID");

                    b.Property<string>("QuestionTxt");

                    b.Property<int>("TestID");

                    b.HasKey("QuestionID");

                    b.HasIndex("TestID");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("EsecureModel.Exam.Response", b =>
                {
                    b.Property<int>("ResponseID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ExaminationID");

                    b.Property<int>("QuestionID");

                    b.Property<int>("ResponseTypeID");

                    b.Property<int>("TestID");

                    b.Property<DateTime>("TimeStamp");

                    b.HasKey("ResponseID");

                    b.HasIndex("ExaminationID");

                    b.ToTable("Response");
                });

            modelBuilder.Entity("EsecureModel.Exam.ResponseType", b =>
                {
                    b.Property<int>("ResponseTypeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ResponseValue");

                    b.HasKey("ResponseTypeID");

                    b.ToTable("ResponseType");
                });

            modelBuilder.Entity("EsecureModel.Exam.Test", b =>
                {
                    b.Property<int>("TestID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("TestID");

                    b.ToTable("Test");
                });

            modelBuilder.Entity("EsecureModel.Faena.Empresa", b =>
                {
                    b.Property<int>("EmpresaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreFantasia");

                    b.Property<int>("PersonaID");

                    b.Property<string>("RazonSocial");

                    b.Property<string>("RutChile");

                    b.HasKey("EmpresaID");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("EsecureModel.Faena.Faena", b =>
                {
                    b.Property<int>("FaenaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmpresaID");

                    b.Property<string>("NombreFaena")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<DateTime>("Timestamp");

                    b.Property<int?>("UbicacionDireccionID");

                    b.Property<DateTime>("Umod");

                    b.HasKey("FaenaID");

                    b.HasIndex("EmpresaID");

                    b.HasIndex("UbicacionDireccionID");

                    b.ToTable("Faena");
                });

            modelBuilder.Entity("EsecureModel.File.FileUp", b =>
                {
                    b.Property<int>("FileUpID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileName");

                    b.Property<int>("FileSize");

                    b.Property<int>("FileTypeID");

                    b.Property<string>("FileUid");

                    b.Property<int>("FolderUpID");

                    b.Property<DateTime>("LastMod");

                    b.Property<int>("PersonaID");

                    b.Property<DateTime>("TimeStamp");

                    b.HasKey("FileUpID");

                    b.HasIndex("FolderUpID");

                    b.ToTable("FileUp");
                });

            modelBuilder.Entity("EsecureModel.File.FileUpType", b =>
                {
                    b.Property<int>("FileUpTypeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileUpTypeName");

                    b.HasKey("FileUpTypeID");

                    b.ToTable("FileUpType");
                });

            modelBuilder.Entity("EsecureModel.File.FolderUp", b =>
                {
                    b.Property<int>("FolderUpID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmpresaID");

                    b.Property<int?>("FolderUpID1");

                    b.Property<string>("FolderUpName")
                        .HasMaxLength(100);

                    b.Property<int>("FolderUpParent");

                    b.Property<DateTime>("LastMod");

                    b.Property<DateTime>("TimeStamp");

                    b.HasKey("FolderUpID");

                    b.HasIndex("FolderUpID1");

                    b.ToTable("FolderUp");
                });

            modelBuilder.Entity("EsecureModel.Issues.IssueItem", b =>
                {
                    b.Property<int>("IssueItemID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion");

                    b.Property<int>("IssueListId");

                    b.HasKey("IssueItemID");

                    b.HasIndex("IssueListId");

                    b.ToTable("IssueItem");
                });

            modelBuilder.Entity("EsecureModel.Issues.IssueList", b =>
                {
                    b.Property<int>("IssueListId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmpresaID");

                    b.Property<string>("Nombre");

                    b.Property<int>("PlanID");

                    b.HasKey("IssueListId");

                    b.HasIndex("PlanID")
                        .IsUnique();

                    b.ToTable("IssueList");
                });

            modelBuilder.Entity("EsecureModel.Location.Direccion", b =>
                {
                    b.Property<int>("DireccionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Calle");

                    b.Property<int>("Comuna");

                    b.Property<int>("EmpresaID");

                    b.Property<int>("Numeracion");

                    b.Property<int>("Pais");

                    b.Property<int>("Region");

                    b.Property<string>("ShortName");

                    b.HasKey("DireccionID");

                    b.ToTable("Direccion");
                });

            modelBuilder.Entity("EsecureModel.Mailer.MailSender", b =>
                {
                    b.Property<int>("MailSenderID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MailSenderFrom");

                    b.Property<string>("MailSenderMessage");

                    b.Property<string>("MailSenderSubject");

                    b.Property<string>("MailSenderTo");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("MailSenderID");

                    b.ToTable("MailSender");
                });

            modelBuilder.Entity("EsecureModel.Parametro.Estado", b =>
                {
                    b.Property<int>("EstadoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescripcionEstado");

                    b.HasKey("EstadoID");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("EsecureModel.Personal.Persona", b =>
                {
                    b.Property<int>("PersonaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alias");

                    b.Property<string>("ApellidoMaterno");

                    b.Property<string>("ApellidoPaterno");

                    b.Property<string>("Documento");

                    b.Property<int>("EmpresaID");

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<string>("PrimerNombre");

                    b.Property<string>("SegundoNombre");

                    b.Property<int>("TipoDocumento");

                    b.HasKey("PersonaID");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("EsecureModel.Planificacion.HistoricoTarea", b =>
                {
                    b.Property<int>("HistoricoTareaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EstadoAnterior");

                    b.Property<string>("Nombre");

                    b.Property<int>("NuevoEstado");

                    b.Property<int>("TareaID");

                    b.Property<DateTime>("TimeStamp");

                    b.HasKey("HistoricoTareaID");

                    b.ToTable("HistoricoTarea");
                });

            modelBuilder.Entity("EsecureModel.Planificacion.ListaDeTareas", b =>
                {
                    b.Property<int>("ListaDeTareasID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.Property<int>("PlanID");

                    b.HasKey("ListaDeTareasID");

                    b.HasIndex("PlanID")
                        .IsUnique();

                    b.ToTable("ListaDeTareas");
                });

            modelBuilder.Entity("EsecureModel.Planificacion.Plan", b =>
                {
                    b.Property<int>("PlanID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int>("EmpresaID");

                    b.Property<string>("NombrePlan");

                    b.Property<int>("PersonaID");

                    b.Property<DateTime>("TimeStamp");

                    b.Property<DateTime>("Umod");

                    b.HasKey("PlanID");

                    b.HasIndex("EmpresaID");

                    b.HasIndex("PersonaID");

                    b.ToTable("Plan");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Plan");
                });

            modelBuilder.Entity("EsecureModel.Planificacion.Tarea", b =>
                {
                    b.Property<int>("TareaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmpresaID");

                    b.Property<int>("EstadoID");

                    b.Property<int>("FaenaID");

                    b.Property<DateTime?>("FechaEjecucionReal");

                    b.Property<DateTime?>("FechaFinEjecucionReal");

                    b.Property<DateTime>("FechaFinPlanificada");

                    b.Property<DateTime>("FechaPlanificada");

                    b.Property<DateTime?>("FechaUltimaModificacion");

                    b.Property<int?>("ListaDeTareasID");

                    b.Property<string>("NombreTarea");

                    b.Property<int>("PlanID");

                    b.Property<int>("TestID");

                    b.HasKey("TareaID");

                    b.HasIndex("ListaDeTareasID");

                    b.ToTable("Tarea");
                });

            modelBuilder.Entity("EsecureModel.Soporte.Ticket", b =>
                {
                    b.Property<int>("TicketID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Mensaje");

                    b.Property<string>("Nombre");

                    b.HasKey("TicketID");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("EsecureModel.Usuario.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<int>("ApplicationUserID");

                    b.Property<string>("City");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Country");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<int>("EmpresaID");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Province");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Street");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("EmpresaID");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("EsecureModel.Verificaciones.ActividadVerificacion", b =>
                {
                    b.Property<int>("ActividadVerificacionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion");

                    b.Property<int>("EmpresaID");

                    b.HasKey("ActividadVerificacionID");

                    b.ToTable("ActividadVerificacion");
                });

            modelBuilder.Entity("EsecureModel.Verificaciones.Dimension", b =>
                {
                    b.Property<int>("DimensionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion");

                    b.HasKey("DimensionID");

                    b.ToTable("Dimension");
                });

            modelBuilder.Entity("EsecureModel.Verificaciones.ItemVerificacion", b =>
                {
                    b.Property<int>("ItemVerificacionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActividadVerificacionID");

                    b.Property<int?>("DimensionID");

                    b.Property<string>("Glosa");

                    b.HasKey("ItemVerificacionID");

                    b.HasIndex("ActividadVerificacionID");

                    b.HasIndex("DimensionID");

                    b.ToTable("ItemVerificacion");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("EsecureModel.Planificacion.PlanPrevencion", b =>
                {
                    b.HasBaseType("EsecureModel.Planificacion.Plan");


                    b.ToTable("PlanPrevencion");

                    b.HasDiscriminator().HasValue("PlanPrevencion");
                });

            modelBuilder.Entity("EsecureModel.Exam.Evidence", b =>
                {
                    b.HasOne("EsecureModel.Exam.EvidenceType", "EvidenceType")
                        .WithMany()
                        .HasForeignKey("EvidenceTypeID");

                    b.HasOne("EsecureModel.File.FileUp", "FileUp")
                        .WithMany()
                        .HasForeignKey("FileUpID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EsecureModel.Exam.Response")
                        .WithMany("EvidenceList")
                        .HasForeignKey("ResponseID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EsecureModel.Exam.Examination", b =>
                {
                    b.HasOne("EsecureModel.Exam.Test", "Prueba")
                        .WithMany()
                        .HasForeignKey("TestID");
                });

            modelBuilder.Entity("EsecureModel.Exam.Question", b =>
                {
                    b.HasOne("EsecureModel.Exam.Test")
                        .WithMany("QuestionList")
                        .HasForeignKey("TestID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EsecureModel.Exam.Response", b =>
                {
                    b.HasOne("EsecureModel.Exam.Examination")
                        .WithMany("ListaRespuestas")
                        .HasForeignKey("ExaminationID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EsecureModel.Faena.Faena", b =>
                {
                    b.HasOne("EsecureModel.Faena.Empresa")
                        .WithMany("Faenas")
                        .HasForeignKey("EmpresaID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EsecureModel.Location.Direccion", "Ubicacion")
                        .WithMany()
                        .HasForeignKey("UbicacionDireccionID");
                });

            modelBuilder.Entity("EsecureModel.File.FileUp", b =>
                {
                    b.HasOne("EsecureModel.File.FolderUp")
                        .WithMany("FolderUpFiles")
                        .HasForeignKey("FolderUpID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EsecureModel.File.FolderUp", b =>
                {
                    b.HasOne("EsecureModel.File.FolderUp")
                        .WithMany("FolderUpFolders")
                        .HasForeignKey("FolderUpID1");
                });

            modelBuilder.Entity("EsecureModel.Issues.IssueItem", b =>
                {
                    b.HasOne("EsecureModel.Issues.IssueList")
                        .WithMany("ListaIssues")
                        .HasForeignKey("IssueListId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EsecureModel.Issues.IssueList", b =>
                {
                    b.HasOne("EsecureModel.Planificacion.Plan")
                        .WithOne("ListaDeIssues")
                        .HasForeignKey("EsecureModel.Issues.IssueList", "PlanID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EsecureModel.Planificacion.ListaDeTareas", b =>
                {
                    b.HasOne("EsecureModel.Planificacion.Plan")
                        .WithOne("ListaTareas")
                        .HasForeignKey("EsecureModel.Planificacion.ListaDeTareas", "PlanID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EsecureModel.Planificacion.Plan", b =>
                {
                    b.HasOne("EsecureModel.Faena.Empresa", "Empresa")
                        .WithMany("Planes")
                        .HasForeignKey("EmpresaID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EsecureModel.Personal.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EsecureModel.Planificacion.Tarea", b =>
                {
                    b.HasOne("EsecureModel.Planificacion.ListaDeTareas")
                        .WithMany("ListaTareas")
                        .HasForeignKey("ListaDeTareasID");
                });

            modelBuilder.Entity("EsecureModel.Usuario.ApplicationUser", b =>
                {
                    b.HasOne("EsecureModel.Faena.Empresa")
                        .WithMany("ListaUsuarios")
                        .HasForeignKey("EmpresaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EsecureModel.Verificaciones.ItemVerificacion", b =>
                {
                    b.HasOne("EsecureModel.Verificaciones.ActividadVerificacion")
                        .WithMany("ListaVerificacion")
                        .HasForeignKey("ActividadVerificacionID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EsecureModel.Verificaciones.Dimension", "Dimension")
                        .WithMany()
                        .HasForeignKey("DimensionID");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("EsecureModel.Usuario.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EsecureModel.Usuario.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EsecureModel.Usuario.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("EsecureModel.Usuario.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
