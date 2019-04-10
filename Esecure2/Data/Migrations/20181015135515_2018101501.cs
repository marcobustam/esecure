using Microsoft.EntityFrameworkCore.Migrations;

namespace Esecure2.Data.Migrations
{
    public partial class _2018101501 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpresaID",
                table: "Tarea",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmpresaID",
                table: "Tarea");
        }
    }
}
