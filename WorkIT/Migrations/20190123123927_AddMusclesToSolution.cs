using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkIT.Migrations
{
    public partial class AddMusclesToSolution : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "muscles",
                columns: table => new
                {
                    muscleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_muscles", x => x.muscleId);
                });

            migrationBuilder.CreateTable(
                name: "musclesExerciseType",
                columns: table => new
                {
                    exerciseTypeId = table.Column<int>(nullable: false),
                    muscleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_musclesExerciseType", x => new { x.exerciseTypeId, x.muscleId });
                    table.ForeignKey(
                        name: "FK_musclesExerciseType_ExerciseType_exerciseTypeId",
                        column: x => x.exerciseTypeId,
                        principalTable: "ExerciseType",
                        principalColumn: "exerciseTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_musclesExerciseType_muscles_muscleId",
                        column: x => x.muscleId,
                        principalTable: "muscles",
                        principalColumn: "muscleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_musclesExerciseType_muscleId",
                table: "musclesExerciseType",
                column: "muscleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "musclesExerciseType");

            migrationBuilder.DropTable(
                name: "muscles");
        }
    }
}
