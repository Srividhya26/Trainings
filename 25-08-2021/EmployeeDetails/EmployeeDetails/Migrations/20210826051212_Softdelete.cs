using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeDetails.Migrations
{
    public partial class Softdelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DelStatus",
                table: "Employee",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DelStatus",
                table: "Employee");
        }
    }
}
