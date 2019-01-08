using System.Collections.Generic;

namespace WorkIT.Models
{
    public class Exercise
    {
        public int ExerciseId { get; set; }
        public int WorkoutId { get; set; }

        public int ExerciseTypeId { get; set; }
        public ExerciseType ExerciseType { get; set; }

        public int? Duration { get; set; }

        public ICollection<Set> Sets { get; set; }

    }
}
