using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Esecure2.Data.Migrations
{
    public partial class _2018090602 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IssueList",
                columns: table => new
                {
                    IssueListId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    PlanID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssueList", x => x.IssueListId);
                    table.ForeignKey(
                        name: "FK_IssueList_Plan_PlanID",
                        column: x => x.PlanID,
                        principalTable: "Plan",
                        principalColumn: "PlanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IssueItem",
                columns: table => new
                {
                    IssueItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true),
                    IssueListId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssueItem", x => x.IssueItemID);
                    table.ForeignKey(
                        name: "FK_IssueItem_IssueList_IssueListId",
                        column: x => x.IssueListId,
                        principalTable: "IssueList",
                        principalColumn: "IssueListId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IssueItem_IssueListId",
                table: "IssueItem",
                column: "IssueListId");

            migrationBuilder.CreateIndex(
                name: "IX_IssueList_PlanID",
                table: "IssueList",
                column: "PlanID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IssueItem");

            migrationBuilder.DropTable(
                name: "IssueList");
        }
    }
}
