using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkIT.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExerciseType",
                columns: table => new
                {
                    exerciseTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseType", x => x.exerciseTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Workout",
                columns: table => new
                {
                    workoutId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    startDateTime = table.Column<DateTime>(nullable: false),
                    endDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workout", x => x.workoutId);
                });

            migrationBuilder.CreateTable(
                name: "Exercise",
                columns: table => new
                {
                    exerciseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    workoutId = table.Column<int>(nullable: false),
                    exerciseTypeId = table.Column<int>(nullable: false),
                    duration = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise", x => x.exerciseId);
                    table.ForeignKey(
                        name: "FK_Exercise_Workout_workoutId",
                        column: x => x.workoutId,
                        principalTable: "Workout",
                        principalColumn: "workoutId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Set",
                columns: table => new
                {
                    setId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    exerciseId = table.Column<int>(nullable: false),
                    repCount = table.Column<int>(nullable: false),
                    restTime = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Set", x => x.setId);
                    table.ForeignKey(
                        name: "FK_Set_Exercise_exerciseId",
                        column: x => x.exerciseId,
                        principalTable: "Exercise",
                        principalColumn: "exerciseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_workoutId",
                table: "Exercise",
                column: "workoutId");

            migrationBuilder.CreateIndex(
                name: "IX_Set_exerciseId",
                table: "Set",
                column: "exerciseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseType");

            migrationBuilder.DropTable(
                name: "Set");

            migrationBuilder.DropTable(
                name: "Exercise");

            migrationBuilder.DropTable(
                name: "Workout");
        }
    }
}
