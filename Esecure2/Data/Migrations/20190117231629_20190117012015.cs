using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Esecure2.Data.Migrations
{
    public partial class _20190117012015 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "CreatedDate",
            //    table: "AspNetRoles");

            //migrationBuilder.DropColumn(
            //    name: "Description",
            //    table: "AspNetRoles");

            //migrationBuilder.DropColumn(
            //    name: "IdentityRoleDescriptor",
            //    table: "AspNetRoles");

            //migrationBuilder.DropColumn(
            //    name: "IdentityRoleID",
            //    table: "AspNetRoles");

            //migrationBuilder.DropColumn(
            //    name: "IdentityRoleName",
            //    table: "AspNetRoles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AspNetRoles",
                nullable: true);

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
    }
}
