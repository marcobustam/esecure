using Microsoft.EntityFrameworkCore.Migrations;

namespace Esecure2.Data.Migrations
{
    public partial class _2019022701 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evidence_Response_ResponseID",
                table: "Evidence");

            migrationBuilder.AlterColumn<int>(
                name: "ResponseID",
                table: "Evidence",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Evidence_Response_ResponseID",
                table: "Evidence",
                column: "ResponseID",
                principalTable: "Response",
                principalColumn: "ResponseID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evidence_Response_ResponseID",
                table: "Evidence");

            migrationBuilder.AlterColumn<int>(
                name: "ResponseID",
                table: "Evidence",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Evidence_Response_ResponseID",
                table: "Evidence",
                column: "ResponseID",
                principalTable: "Response",
                principalColumn: "ResponseID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
