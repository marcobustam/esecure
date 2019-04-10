using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Esecure2.Data.Migrations
{
    public partial class _2018101701 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaFinEjecucionReal",
                table: "Tarea",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaFinPlanificada",
                table: "Tarea",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaFinEjecucionReal",
                table: "Tarea");

            migrationBuilder.DropColumn(
                name: "FechaFinPlanificada",
                table: "Tarea");
        }
    }
}
