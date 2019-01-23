using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkIT.Migrations
{
    public partial class MakeModelsUppercase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_musclesExerciseType_ExerciseType_exerciseTypeId",
                table: "musclesExerciseType");

            migrationBuilder.DropForeignKey(
                name: "FK_musclesExerciseType_muscles_muscleId",
                table: "musclesExerciseType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_musclesExerciseType",
                table: "musclesExerciseType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_muscles",
                table: "muscles");

            migrationBuilder.RenameTable(
                name: "musclesExerciseType",
                newName: "MusclesExerciseType");

            migrationBuilder.RenameTable(
                name: "muscles",
                newName: "Muscles");

            migrationBuilder.RenameIndex(
                name: "IX_musclesExerciseType_muscleId",
                table: "MusclesExerciseType",
                newName: "IX_MusclesExerciseType_muscleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MusclesExerciseType",
                table: "MusclesExerciseType",
                columns: new[] { "exerciseTypeId", "muscleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Muscles",
                table: "Muscles",
                column: "muscleId");

            migrationBuilder.AddForeignKey(
                name: "FK_MusclesExerciseType_ExerciseType_exerciseTypeId",
                table: "MusclesExerciseType",
                column: "exerciseTypeId",
                principalTable: "ExerciseType",
                principalColumn: "exerciseTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MusclesExerciseType_Muscles_muscleId",
                table: "MusclesExerciseType",
                column: "muscleId",
                principalTable: "Muscles",
                principalColumn: "muscleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MusclesExerciseType_ExerciseType_exerciseTypeId",
                table: "MusclesExerciseType");

            migrationBuilder.DropForeignKey(
                name: "FK_MusclesExerciseType_Muscles_muscleId",
                table: "MusclesExerciseType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MusclesExerciseType",
                table: "MusclesExerciseType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Muscles",
                table: "Muscles");

            migrationBuilder.RenameTable(
                name: "MusclesExerciseType",
                newName: "musclesExerciseType");

            migrationBuilder.RenameTable(
                name: "Muscles",
                newName: "muscles");

            migrationBuilder.RenameIndex(
                name: "IX_MusclesExerciseType_muscleId",
                table: "musclesExerciseType",
                newName: "IX_musclesExerciseType_muscleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_musclesExerciseType",
                table: "musclesExerciseType",
                columns: new[] { "exerciseTypeId", "muscleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_muscles",
                table: "muscles",
                column: "muscleId");

            migrationBuilder.AddForeignKey(
                name: "FK_musclesExerciseType_ExerciseType_exerciseTypeId",
                table: "musclesExerciseType",
                column: "exerciseTypeId",
                principalTable: "ExerciseType",
                principalColumn: "exerciseTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_musclesExerciseType_muscles_muscleId",
                table: "musclesExerciseType",
                column: "muscleId",
                principalTable: "muscles",
                principalColumn: "muscleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
