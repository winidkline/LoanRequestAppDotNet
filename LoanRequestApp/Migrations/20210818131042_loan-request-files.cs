using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanRequestApp.Migrations
{
    public partial class loanrequestfiles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoanRequestFiles",
                columns: table => new
                {
                    LoanRequestFileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanRequestId = table.Column<int>(nullable: false),
                    Filename = table.Column<string>(nullable: true),
                    Filepath = table.Column<string>(nullable: true),
                    Approved = table.Column<bool>(nullable: false),
                    IsP080A = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanRequestFiles", x => x.LoanRequestFileId);
                    table.ForeignKey(
                        name: "FK_LoanRequestFiles_LoanRequests_LoanRequestId",
                        column: x => x.LoanRequestId,
                        principalTable: "LoanRequests",
                        principalColumn: "LoanRequestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LoanRequestFiles_LoanRequestId",
                table: "LoanRequestFiles",
                column: "LoanRequestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoanRequestFiles");
        }
    }
}
