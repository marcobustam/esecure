using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Esecure2.Data.Migrations
{
    public partial class _2018090401 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tarea",
                columns: table => new
                {
                    TareaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlanID = table.Column<int>(nullable: false),
                    NombreTarea = table.Column<string>(nullable: true),
                    FechaPlanificada = table.Column<DateTime>(nullable: false),
                    FechaEjecucionReal = table.Column<DateTime>(nullable: false),
                    EstadoID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarea", x => x.TareaID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Plan_EmpresaID",
                table: "Plan",
                column: "EmpresaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Plan_Empresa_EmpresaID",
                table: "Plan",
                column: "EmpresaID",
                principalTable: "Empresa",
                principalColumn: "EmpresaID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plan_Empresa_EmpresaID",
                table: "Plan");

            migrationBuilder.DropTable(
                name: "Tarea");

            migrationBuilder.DropIndex(
                name: "IX_Plan_EmpresaID",
                table: "Plan");
        }
    }
}
