using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication5.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BankBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchManager", "EmployeeCount" },
                values: new object[] { "Omar Alkandrii", 21 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BankBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BranchManager", "EmployeeCount" },
                values: new object[] { "Abdulrahman", 7 });
        }
    }
}
