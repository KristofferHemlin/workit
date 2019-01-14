using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkIT.Migrations
{
    public partial class AddWeightToSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "weight",
                table: "Set",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "weight",
                table: "Set");
        }
    }
}
