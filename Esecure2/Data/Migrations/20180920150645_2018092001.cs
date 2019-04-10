using Microsoft.EntityFrameworkCore.Migrations;

namespace Esecure2.Data.Migrations
{
    public partial class _2018092001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarea_Test_ChecklistTestID",
                table: "Tarea");

            migrationBuilder.DropIndex(
                name: "IX_Tarea_ChecklistTestID",
                table: "Tarea");

            migrationBuilder.DropColumn(
                name: "ChecklistTestID",
                table: "Tarea");
        }
    }
}
