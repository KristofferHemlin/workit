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
        public async Task<ActionResult<Workout>> AddWorkout(Workout work)
        {
            _context.Workout.Add(work);
            
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAllWorkouts", new { id = work.workoutId });

        }
        [HttpPut("{workoutId}")]
        public async Task<IActionResult> UpdateWorkout(long workoutId, Workout work)
        {
            if(workoutId != work.workoutId)
            {
                return BadRequest();
            }
            _context.Entry(work).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetAllWorkouts", new { work });
        }



        [HttpDelete("{workoutId}")]
        public async Task<ActionResult<Workout>> DeleteWorkout(int workoutId)
        {
            var workout = await _context.Workout.FindAsync(workoutId);
            if(workout == null)
            {
                return NotFound();
            }
            _context.Workout.Remove(workout);
            await _context.SaveChangesAsync();


            return workout;
        }
    }
}