using System.Collections.Generic;

namespace WorkIT.Models
{
    public class Exercise
    {
        public int exerciseId { get; set; }
        public int workoutId { get; set; }

        public int exerciseTypeId { get; set; }
        public int duration { get; set; }

        public ICollection<Set> Sets { get; set; }

    }
}
