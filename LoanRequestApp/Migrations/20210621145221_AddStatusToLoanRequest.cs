using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanRequestApp.Migrations
{
    public partial class AddStatusToLoanRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "LoanRequests",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "LoanRequests");
        }
    }
}
