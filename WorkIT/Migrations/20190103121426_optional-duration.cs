using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkIT.Migrations
{
    public partial class optionalduration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercise_Workout_workoutId",
                table: "Exercise");

            migrationBuilder.RenameColumn(
                name: "workoutId",
                table: "Exercise",
                newName: "WorkoutId");

            migrationBuilder.RenameColumn(
                name: "exerciseTypeId",
                table: "Exercise",
                newName: "ExerciseTypeId");

            migrationBuilder.RenameColumn(
                name: "duration",
                table: "Exercise",
                newName: "Duration");

            migrationBuilder.RenameColumn(
                name: "exerciseId",
                table: "Exercise",
                newName: "ExerciseId");

            migrationBuilder.RenameIndex(
                name: "IX_Exercise_workoutId",
                table: "Exercise",
                newName: "IX_Exercise_WorkoutId");

            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "Exercise",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_ExerciseTypeId",
                table: "Exercise",
                column: "ExerciseTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercise_ExerciseType_ExerciseTypeId",
                table: "Exercise",
                column: "ExerciseTypeId",
                principalTable: "ExerciseType",
                principalColumn: "exerciseTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exercise_Workout_WorkoutId",
                table: "Exercise",
                column: "WorkoutId",
                principalTable: "Workout",
                principalColumn: "workoutId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercise_ExerciseType_ExerciseTypeId",
                table: "Exercise");

            migrationBuilder.DropForeignKey(
                name: "FK_Exercise_Workout_WorkoutId",
                table: "Exercise");

            migrationBuilder.DropIndex(
                name: "IX_Exercise_ExerciseTypeId",
                table: "Exercise");

            migrationBuilder.RenameColumn(
                name: "WorkoutId",
                table: "Exercise",
                newName: "workoutId");

            migrationBuilder.RenameColumn(
                name: "ExerciseTypeId",
                table: "Exercise",
                newName: "exerciseTypeId");

            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "Exercise",
                newName: "duration");

            migrationBuilder.RenameColumn(
                name: "ExerciseId",
                table: "Exercise",
                newName: "exerciseId");

            migrationBuilder.RenameIndex(
                name: "IX_Exercise_WorkoutId",
                table: "Exercise",
                newName: "IX_Exercise_workoutId");

            migrationBuilder.AlterColumn<int>(
                name: "duration",
                table: "Exercise",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Exercise_Workout_workoutId",
                table: "Exercise",
                column: "workoutId",
                principalTable: "Workout",
                principalColumn: "workoutId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
