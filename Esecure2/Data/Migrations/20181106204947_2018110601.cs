using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Esecure2.Data.Migrations
{
    public partial class _2018110601 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpresaID",
                table: "Persona",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoDocumento",
                table: "Persona",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Evidence",
                columns: table => new
                {
                    EvidenceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true),
                    EvidenceType = table.Column<int>(nullable: false),
                    FileUpID = table.Column<int>(nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    LastMod = table.Column<DateTime>(nullable: false),
                    PersonaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evidence", x => x.EvidenceID);
                    table.ForeignKey(
                        name: "FK_Evidence_FileUp_FileUpID",
                        column: x => x.FileUpID,
                        principalTable: "FileUp",
                        principalColumn: "FileUpID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Evidence_FileUpID",
                table: "Evidence",
                column: "FileUpID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evidence");

            migrationBuilder.DropColumn(
                name: "EmpresaID",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "TipoDocumento",
                table: "Persona");
        }
    }
}
