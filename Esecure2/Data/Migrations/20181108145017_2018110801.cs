using Microsoft.EntityFrameworkCore.Migrations;

namespace Esecure2.Data.Migrations
{
    public partial class _2018110801 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evidence_FileUp_FileUpID",
                table: "Evidence");

            migrationBuilder.AlterColumn<int>(
                name: "FileUpID",
                table: "Evidence",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResponseID",
                table: "Evidence",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Evidence_ResponseID",
                table: "Evidence",
                column: "ResponseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Evidence_FileUp_FileUpID",
                table: "Evidence",
                column: "FileUpID",
                principalTable: "FileUp",
                principalColumn: "FileUpID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Evidence_Response_ResponseID",
                table: "Evidence",
                column: "ResponseID",
                principalTable: "Response",
                principalColumn: "ResponseID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evidence_FileUp_FileUpID",
                table: "Evidence");

            migrationBuilder.DropForeignKey(
                name: "FK_Evidence_Response_ResponseID",
                table: "Evidence");

            migrationBuilder.DropIndex(
                name: "IX_Evidence_ResponseID",
                table: "Evidence");

            migrationBuilder.DropColumn(
                name: "ResponseID",
                table: "Evidence");

            migrationBuilder.AlterColumn<int>(
                name: "FileUpID",
                table: "Evidence",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Evidence_FileUp_FileUpID",
                table: "Evidence",
                column: "FileUpID",
                principalTable: "FileUp",
                principalColumn: "FileUpID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
