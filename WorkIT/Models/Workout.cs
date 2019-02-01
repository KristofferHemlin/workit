using System;
using System.Collections.Generic;

namespace WorkIT.Models
{
    public class Workout
    {
        public int workoutId { get; set; }
        public DateTime startDateTime { get; set; }
        public DateTime endDateTime { get; set; }
        public string name { get; set; }

        public ICollection<Exercise> Exercises { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as Workout;

            if (other == null)
                return false;

            if (workoutId != other.workoutId || startDateTime != other.startDateTime || endDateTime != other.endDateTime)
                return false;

            return true;
        }
    }
}

