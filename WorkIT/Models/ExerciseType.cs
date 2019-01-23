using System.Collections.Generic;

namespace WorkIT.Models
{
    public class ExerciseType
    {
        public int exerciseTypeId { get; set; }
        public string name { get; set; }

        public ICollection<MusclesExerciseType> Muscles { get; set; }
    }
}
