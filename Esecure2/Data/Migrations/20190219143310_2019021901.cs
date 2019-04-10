using Microsoft.EntityFrameworkCore.Migrations;

namespace Esecure2.Data.Migrations
{
    public partial class _2019021901 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpresaID",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EmpresaID",
                table: "AspNetUsers",
                column: "EmpresaID");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_AspNetUsers_Empresa_EmpresaID",
            //    table: "AspNetUsers",
            //    column: "EmpresaID",
            //    principalTable: "Empresa",
            //    principalColumn: "EmpresaID",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Empresa_EmpresaID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_EmpresaID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EmpresaID",
                table: "AspNetUsers");
        }
    }
}
