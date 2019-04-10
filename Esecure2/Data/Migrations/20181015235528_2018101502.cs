using Microsoft.EntityFrameworkCore.Migrations;

namespace Esecure2.Data.Migrations
{
    public partial class _2018101502 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FaenaID",
                table: "Tarea",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FaenaID",
                table: "Tarea");
        }
    }
}
