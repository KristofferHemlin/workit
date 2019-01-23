using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkIT.Models
{
    public class Muscle
    {
        public int muscleId { get; set; }
        public string name { get; set; }

        public ICollection<MusclesExerciseType> ExerciseTypes { get; set; }
    }
}
