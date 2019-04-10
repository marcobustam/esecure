using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Esecure2.Data.Migrations
{
    public partial class _2018092402 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UbicacionDireccionID",
                table: "Faena",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Direccion",
                columns: table => new
                {
                    DireccionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmpresaID = table.Column<int>(nullable: false),
                    ShortName = table.Column<string>(nullable: true),
                    Calle = table.Column<string>(nullable: true),
                    Numeracion = table.Column<int>(nullable: false),
                    Comuna = table.Column<int>(nullable: false),
                    Region = table.Column<int>(nullable: false),
                    Pais = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direccion", x => x.DireccionID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Faena_UbicacionDireccionID",
                table: "Faena",
                column: "UbicacionDireccionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Faena_Direccion_UbicacionDireccionID",
                table: "Faena",
                column: "UbicacionDireccionID",
                principalTable: "Direccion",
                principalColumn: "DireccionID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faena_Direccion_UbicacionDireccionID",
                table: "Faena");

            migrationBuilder.DropTable(
                name: "Direccion");

            migrationBuilder.DropIndex(
                name: "IX_Faena_UbicacionDireccionID",
                table: "Faena");

            migrationBuilder.DropColumn(
                name: "UbicacionDireccionID",
                table: "Faena");
        }
    }
}
