namespace WorkIT.Models
{
    public class MusclesExerciseType
    {
        public int exerciseTypeId { get; set; }
        public ExerciseType ExerciseType { get; set; }

        public int muscleId { get; set; }
        public Muscle Muscle { get; set; }
    }
}
