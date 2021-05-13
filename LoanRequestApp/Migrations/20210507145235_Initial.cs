using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanRequestApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoanRequestAssetTypes",
                columns: table => new
                {
                    LoanRequestAssetTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanRequestAssetTypes", x => x.LoanRequestAssetTypeId);
                });

            migrationBuilder.CreateTable(
                name: "LoanRequests",
                columns: table => new
                {
                    LoanRequestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    TermValue = table.Column<int>(nullable: false),
                    TermUnit = table.Column<int>(nullable: false),
                    Requested = table.Column<DateTime>(nullable: true),
                    Submitted = table.Column<DateTime>(nullable: false),
                    Approved = table.Column<DateTime>(nullable: true),
                    HasProcessed = table.Column<bool>(nullable: false),
                    P080APath = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanRequests", x => x.LoanRequestId);
                });

            migrationBuilder.CreateTable(
                name: "LoanRequestAssets",
                columns: table => new
                {
                    LoanRequestAssetId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanRequestId = table.Column<int>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanRequestAssets", x => x.LoanRequestAssetId);
                    table.ForeignKey(
                        name: "FK_LoanRequestAssets_LoanRequests_LoanRequestId",
                        column: x => x.LoanRequestId,
                        principalTable: "LoanRequests",
                        principalColumn: "LoanRequestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LoanRequestAssets_LoanRequestId",
                table: "LoanRequestAssets",
                column: "LoanRequestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoanRequestAssets");

            migrationBuilder.DropTable(
                name: "LoanRequestAssetTypes");

            migrationBuilder.DropTable(
                name: "LoanRequests");
        }
    }
}
