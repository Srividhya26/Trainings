using Microsoft.EntityFrameworkCore.Migrations;

namespace Employees.Migrations
{
    public partial class updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employee_skill_SkillId",
                table: "employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_skill",
                table: "skill");

            migrationBuilder.RenameTable(
                name: "skill",
                newName: "Skills");

            migrationBuilder.RenameIndex(
                name: "IX_skill_SkillName",
                table: "Skills",
                newName: "IX_Skills_SkillName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skills",
                table: "Skills",
                column: "SkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_employee_Skills_SkillId",
                table: "employee",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "SkillId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employee_Skills_SkillId",
                table: "employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skills",
                table: "Skills");

            migrationBuilder.RenameTable(
                name: "Skills",
                newName: "skill");

            migrationBuilder.RenameIndex(
                name: "IX_Skills_SkillName",
                table: "skill",
                newName: "IX_skill_SkillName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_skill",
                table: "skill",
                column: "SkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_employee_skill_SkillId",
                table: "employee",
                column: "SkillId",
                principalTable: "skill",
                principalColumn: "SkillId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
