using Microsoft.EntityFrameworkCore.Migrations;

namespace Esecure2.Data.Migrations
{
    public partial class _2018090701 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActividadVerificacionID",
                table: "Tarea",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_ActividadVerificacionID",
                table: "Tarea",
                column: "ActividadVerificacionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarea_ActividadVerificacion_ActividadVerificacionID",
                table: "Tarea",
                column: "ActividadVerificacionID",
                principalTable: "ActividadVerificacion",
                principalColumn: "ActividadVerificacionID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarea_ActividadVerificacion_ActividadVerificacionID",
                table: "Tarea");

            migrationBuilder.DropIndex(
                name: "IX_Tarea_ActividadVerificacionID",
                table: "Tarea");

            migrationBuilder.DropColumn(
                name: "ActividadVerificacionID",
                table: "Tarea");
        }
    }
}
