using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkIT.Models;

namespace WorkIT.Data
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public WorkController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Workout>> GetAllWorkouts()
        {
            return _context.Workout
                .Include(w => w.Exercises).ThenInclude(e => e.ExerciseType)
                .Include(w => w.Exercises).ThenInclude(e => e.Sets)
                
                    
                .ToList();
        }

        [HttpPost]
        public async Task<ActionResult> AddWorkout(Workout work)
        {
            _context.Workout.Add(work);
            foreach (var e in work.Exercises)
            {
                Exercise exercise = new Exercise
                {
                    ExerciseTypeId = e.ExerciseTypeId,
                    WorkoutId = work.workoutId,
                    Duration = e.Duration
                   
                };
                _context.Exercise.Add(e);

                foreach(var s in e.Sets)
                {
                    Set set = new Set
                    {
                        exerciseId = e.ExerciseId,
                        weight = s.weight,
                        repCount = s.repCount,
                        restTime = s.restTime
                    };
                    _context.Set.Add(s);

                }
            }
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAllWorkouts", new { id = work.workoutId });

        }
    }
}