using Microsoft.EntityFrameworkCore.Migrations;

namespace RPFGOAccount.Migrations
{
    public partial class Class : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Character",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Class",
                table: "Character");
        }
    }
}
