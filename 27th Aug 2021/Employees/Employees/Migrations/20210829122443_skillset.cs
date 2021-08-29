using Microsoft.EntityFrameworkCore.Migrations;

namespace Employees.Migrations
{
    public partial class skillset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "SkillName",
                table: "skill",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_skill",
                table: "skill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_skill_SkillName",
                table: "skill",
                column: "SkillName",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_employee_skill_SkillId",
                table: "employee",
                column: "SkillId",
                principalTable: "skill",
                principalColumn: "SkillId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employee_skill_SkillId",
                table: "employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_skill",
                table: "skill");

            migrationBuilder.DropIndex(
                name: "IX_skill_SkillName",
                table: "skill");

            migrationBuilder.RenameTable(
                name: "skill",
                newName: "Skills");

            migrationBuilder.AlterColumn<string>(
                name: "SkillName",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
    }
}
