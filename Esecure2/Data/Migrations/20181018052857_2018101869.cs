using Microsoft.EntityFrameworkCore.Migrations;

namespace Esecure2.Data.Migrations
{
    public partial class _2018101869 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TestID",
                table: "Tarea",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_TestID",
                table: "Tarea",
                column: "TestID");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarea_Test_TestID",
                table: "Tarea");

            migrationBuilder.DropIndex(
                name: "IX_Tarea_TestID",
                table: "Tarea");

            migrationBuilder.DropColumn(
                name: "TestID",
                table: "Tarea");

            migrationBuilder.AddColumn<int>(
                name: "ChecklistTestID",
                table: "Tarea",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_ChecklistTestID",
                table: "Tarea",
                column: "ChecklistTestID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarea_Test_ChecklistTestID",
                table: "Tarea",
                column: "ChecklistTestID",
                principalTable: "Test",
                principalColumn: "TestID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
