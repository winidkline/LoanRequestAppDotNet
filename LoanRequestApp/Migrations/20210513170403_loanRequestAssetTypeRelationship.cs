using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanRequestApp.Migrations
{
    public partial class loanRequestAssetTypeRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LoanRequestAssetTypeId",
                table: "LoanRequestAssets",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LoanRequestAssets_LoanRequestAssetTypeId",
                table: "LoanRequestAssets",
                column: "LoanRequestAssetTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_LoanRequestAssets_LoanRequestAssetTypes_LoanRequestAssetTypeId",
                table: "LoanRequestAssets",
                column: "LoanRequestAssetTypeId",
                principalTable: "LoanRequestAssetTypes",
                principalColumn: "LoanRequestAssetTypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoanRequestAssets_LoanRequestAssetTypes_LoanRequestAssetTypeId",
                table: "LoanRequestAssets");

            migrationBuilder.DropIndex(
                name: "IX_LoanRequestAssets_LoanRequestAssetTypeId",
                table: "LoanRequestAssets");

            migrationBuilder.DropColumn(
                name: "LoanRequestAssetTypeId",
                table: "LoanRequestAssets");
        }
    }
}
