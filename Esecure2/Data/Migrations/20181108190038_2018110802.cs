using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Esecure2.Data.Migrations
{
    public partial class _2018110802 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EvidenceType",
                table: "Evidence");

            migrationBuilder.AddColumn<int>(
                name: "EvidenceTypeID",
                table: "Evidence",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EvidenceType",
                columns: table => new
                {
                    EvidenceTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EvidenceTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvidenceType", x => x.EvidenceTypeID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Evidence_EvidenceTypeID",
                table: "Evidence",
                column: "EvidenceTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Evidence_EvidenceType_EvidenceTypeID",
                table: "Evidence",
                column: "EvidenceTypeID",
                principalTable: "EvidenceType",
                principalColumn: "EvidenceTypeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evidence_EvidenceType_EvidenceTypeID",
                table: "Evidence");

            migrationBuilder.DropTable(
                name: "EvidenceType");

            migrationBuilder.DropIndex(
                name: "IX_Evidence_EvidenceTypeID",
                table: "Evidence");

            migrationBuilder.DropColumn(
                name: "EvidenceTypeID",
                table: "Evidence");

            migrationBuilder.AddColumn<int>(
                name: "EvidenceType",
                table: "Evidence",
                nullable: false,
                defaultValue: 0);
        }
    }
}
