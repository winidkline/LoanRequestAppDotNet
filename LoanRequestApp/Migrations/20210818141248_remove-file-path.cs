using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanRequestApp.Migrations
{
    public partial class removefilepath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Filepath",
                table: "LoanRequestFiles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Filepath",
                table: "LoanRequestFiles",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
