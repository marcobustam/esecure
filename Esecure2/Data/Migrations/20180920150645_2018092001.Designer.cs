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
    [Migration("20180920150645_2018092001")]
    partial class _2018092001
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EsecureModel.Exam.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");
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

                    b.Property<int>("RespuestasCompletadas");

                    b.Property<int>("TestID");

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

                    b.Property<string>("NombreFaena");

                    b.HasKey("FaenaID");

                    b.HasIndex("EmpresaID");

                    b.ToTable("Faena");
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

                    b.Property<string>("Nombre");

                    b.Property<int>("PlanID");

                    b.HasKey("IssueListId");

                    b.HasIndex("PlanID")
                        .IsUnique();

                    b.ToTable("IssueList");
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

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<string>("PrimerNombre");

                    b.Property<string>("SegundoNombre");

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

                    b.Property<int>("EmpresaID");

                    b.Property<string>("NombrePlan");

                    b.Property<int>("PersonaID");

                    b.HasKey("PlanID");

                    b.HasIndex("EmpresaID");

                    b.HasIndex("PersonaID");

                    b.ToTable("Plan");
                });

            modelBuilder.Entity("EsecureModel.Planificacion.Tarea", b =>
                {
                    b.Property<int>("TareaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActividadVerificacionID");

                    b.Property<int?>("ChecklistTestID");

                    b.Property<int>("EstadoID");

                    b.Property<DateTime?>("FechaEjecucionReal");

                    b.Property<DateTime>("FechaPlanificada");

                    b.Property<int?>("ListaDeTareasID");

                    b.Property<string>("NombreTarea");

                    b.Property<int>("PlanID");

                    b.HasKey("TareaID");

                    b.HasIndex("ActividadVerificacionID");

                    b.HasIndex("ChecklistTestID");

                    b.HasIndex("ListaDeTareasID");

                    b.ToTable("Tarea");
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
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
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

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

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("EsecureModel.Exam.Examination", b =>
                {
                    b.HasOne("EsecureModel.Exam.Test", "Prueba")
                        .WithMany()
                        .HasForeignKey("TestID")
                        .OnDelete(DeleteBehavior.Cascade);
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
                    b.HasOne("EsecureModel.Verificaciones.ActividadVerificacion", "Actividad")
                        .WithMany()
                        .HasForeignKey("ActividadVerificacionID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EsecureModel.Exam.Test", "Checklist")
                        .WithMany()
                        .HasForeignKey("ChecklistTestID");

                    b.HasOne("EsecureModel.Planificacion.ListaDeTareas")
                        .WithMany("ListaTareas")
                        .HasForeignKey("ListaDeTareasID");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
