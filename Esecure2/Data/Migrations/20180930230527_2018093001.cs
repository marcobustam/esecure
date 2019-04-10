using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Esecure2.Data.Migrations
{
    public partial class _2018093001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FileUpType",
                columns: table => new
                {
                    FileUpTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FileUpTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileUpType", x => x.FileUpTypeID);
                });

            migrationBuilder.CreateTable(
                name: "FolderUp",
                columns: table => new
                {
                    FolderUpID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FolderUpName = table.Column<string>(maxLength: 20, nullable: true),
                    FolderUpParent = table.Column<int>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    LastMod = table.Column<DateTime>(nullable: false),
                    FolderUpID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FolderUp", x => x.FolderUpID);
                    table.ForeignKey(
                        name: "FK_FolderUp_FolderUp_FolderUpID1",
                        column: x => x.FolderUpID1,
                        principalTable: "FolderUp",
                        principalColumn: "FolderUpID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FileUp",
                columns: table => new
                {
                    FileUpID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FileName = table.Column<string>(nullable: true),
                    FileUid = table.Column<string>(nullable: true),
                    FolderUpID = table.Column<int>(nullable: false),
                    FileTypeID = table.Column<int>(nullable: false),
                    FileSize = table.Column<int>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    LastMod = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileUp", x => x.FileUpID);
                    table.ForeignKey(
                        name: "FK_FileUp_FolderUp_FolderUpID",
                        column: x => x.FolderUpID,
                        principalTable: "FolderUp",
                        principalColumn: "FolderUpID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FileUp_FolderUpID",
                table: "FileUp",
                column: "FolderUpID");

            migrationBuilder.CreateIndex(
                name: "IX_FolderUp_FolderUpID1",
                table: "FolderUp",
                column: "FolderUpID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FileUp");

            migrationBuilder.DropTable(
                name: "FileUpType");

            migrationBuilder.DropTable(
                name: "FolderUp");
        }
    }
}
