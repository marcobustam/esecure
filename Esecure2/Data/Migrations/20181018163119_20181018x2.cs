using Microsoft.EntityFrameworkCore.Migrations;

namespace Esecure2.Data.Migrations
{
    public partial class _20181018x2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropIndex(
                name: "IX_Tarea_TestID",
                table: "Tarea");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Tarea_TestID",
                table: "Tarea",
                column: "TestID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarea_Test_TestID",
                table: "Tarea",
                column: "TestID",
                principalTable: "Test",
                principalColumn: "TestID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
