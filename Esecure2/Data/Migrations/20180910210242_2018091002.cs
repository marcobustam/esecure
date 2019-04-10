using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Esecure2.Data.Migrations
{
    public partial class _2018091002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ListaDeTareasID",
                table: "Tarea",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ListaDeTareas",
                columns: table => new
                {
                    ListaDeTareasID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlanID = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaDeTareas", x => x.ListaDeTareasID);
                    table.ForeignKey(
                        name: "FK_ListaDeTareas_Plan_PlanID",
                        column: x => x.PlanID,
                        principalTable: "Plan",
                        principalColumn: "PlanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_ListaDeTareasID",
                table: "Tarea",
                column: "ListaDeTareasID");

            migrationBuilder.CreateIndex(
                name: "IX_ListaDeTareas_PlanID",
                table: "ListaDeTareas",
                column: "PlanID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarea_ListaDeTareas_ListaDeTareasID",
                table: "Tarea",
                column: "ListaDeTareasID",
                principalTable: "ListaDeTareas",
                principalColumn: "ListaDeTareasID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarea_ListaDeTareas_ListaDeTareasID",
                table: "Tarea");

            migrationBuilder.DropTable(
                name: "ListaDeTareas");

            migrationBuilder.DropIndex(
                name: "IX_Tarea_ListaDeTareasID",
                table: "Tarea");

            migrationBuilder.DropColumn(
                name: "ListaDeTareasID",
                table: "Tarea");
        }
    }
}
