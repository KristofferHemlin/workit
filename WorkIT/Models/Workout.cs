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
    }
}

