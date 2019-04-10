using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Esecure2.Data.Migrations
{
    public partial class _2018121801 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WebConfiguration",
                columns: table => new
                {
                    WebConfigurationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WebConfigurationIndex = table.Column<int>(nullable: false),
                    WebConfigurationGroup = table.Column<string>(nullable: true),
                    WebConfigurationName = table.Column<string>(nullable: true),
                    WebConfigurationValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebConfiguration", x => x.WebConfigurationID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WebConfiguration");
        }
    }
}
