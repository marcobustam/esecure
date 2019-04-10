using Microsoft.EntityFrameworkCore.Migrations;

namespace Esecure2.Data.Migrations
{
    public partial class _2019011401 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ApplicationUserID",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "IdentityRoleDescriptor",
                table: "AspNetRoles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdentityRoleID",
                table: "AspNetRoles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "IdentityRoleName",
                table: "AspNetRoles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicationUserID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IdentityRoleDescriptor",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "IdentityRoleID",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "IdentityRoleName",
                table: "AspNetRoles");
        }
    }
}
