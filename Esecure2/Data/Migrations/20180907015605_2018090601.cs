using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Esecure2.Data.Migrations
{
    public partial class _2018090601 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActividadVerificacion",
                columns: table => new
                {
                    ActividadVerificacionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActividadVerificacion", x => x.ActividadVerificacionID);
                });

            migrationBuilder.CreateTable(
                name: "Dimension",
                columns: table => new
                {
                    DimensionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimension", x => x.DimensionID);
                });

            migrationBuilder.CreateTable(
                name: "ItemVerificacion",
                columns: table => new
                {
                    ItemVerificacionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Glosa = table.Column<string>(nullable: true),
                    DimensionID = table.Column<int>(nullable: true),
                    ActividadVerificacionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemVerificacion", x => x.ItemVerificacionID);
                    table.ForeignKey(
                        name: "FK_ItemVerificacion_ActividadVerificacion_ActividadVerificacionID",
                        column: x => x.ActividadVerificacionID,
                        principalTable: "ActividadVerificacion",
                        principalColumn: "ActividadVerificacionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemVerificacion_Dimension_DimensionID",
                        column: x => x.DimensionID,
                        principalTable: "Dimension",
                        principalColumn: "DimensionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Plan_PersonaID",
                table: "Plan",
                column: "PersonaID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemVerificacion_ActividadVerificacionID",
                table: "ItemVerificacion",
                column: "ActividadVerificacionID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemVerificacion_DimensionID",
                table: "ItemVerificacion",
                column: "DimensionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Plan_Persona_PersonaID",
                table: "Plan",
                column: "PersonaID",
                principalTable: "Persona",
                principalColumn: "PersonaID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plan_Persona_PersonaID",
                table: "Plan");

            migrationBuilder.DropTable(
                name: "ItemVerificacion");

            migrationBuilder.DropTable(
                name: "ActividadVerificacion");

            migrationBuilder.DropTable(
                name: "Dimension");

            migrationBuilder.DropIndex(
                name: "IX_Plan_PersonaID",
                table: "Plan");
        }
    }
}
