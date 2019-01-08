using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkIT.Migrations
{
    public partial class AddNameToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Workout",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "name",
                table: "Workout");
        }
    }
}
