using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WorkIT.Models;
using WorkIT.Repository;

namespace WorkIT.Data
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkController : ControllerBase
    {
        private readonly IRepository<Workout> _workout;
        private readonly IRepository<Exercise> _exercise;
        private readonly IRepository<Set> _set;

        public WorkController(IRepository<Workout> workout, IRepository<Exercise> exercise, IRepository<Set> set)
        {
            _workout = workout;
            _exercise = exercise;
            _set = set;
        }

        [HttpGet]
        public IEnumerable<Workout> GetAllWorkouts()
        {
            return _workout.get();

        }

        //[HttpPost]
        //public async Task<ActionResult<Workout>> AddWorkout(Workout work)
        //{
        //    _workout.create(work);
        //    _context.Workout.Add(work);

        //    await _workout.SaveChangesAsync();


        //    return CreatedAtAction("GetAllWorkouts", new { id = work.workoutId });

        //}
        //[HttpPut("{workoutId}")]
        //public async Task<IActionResult> UpdateWorkout(long workoutId, Workout work)
        //{
        //    if (workoutId != work.workoutId)
        //    {
        //        return BadRequest();
        //    }
        //    _context.Entry(work).State = EntityState.Modified;
        //    await _context.SaveChangesAsync();
        //    return CreatedAtAction("GetAllWorkouts", new { work });
        //}



        //[HttpDelete("{workoutId}")]
        //public async Task<ActionResult<Workout>> DeleteWorkout(int workoutId)
        //{
        //    var workout = await _context.Workout.FindAsync(workoutId);
        //    if(workout == null)
        //    {
        //        return NotFound();
        //    }
        //    _context.Workout.Remove(workout);
        //    await _context.SaveChangesAsync();


        //    return workout;

        [HttpPost]
        public ActionResult AddWorkout(Workout work)
        {
            _workout.create(work);
            _workout.SaveChanges();

            return CreatedAtAction("GetAllWorkouts", new { id = work.workoutId });      
        }
        [HttpPut]
        public IActionResult UpdateWorkout(long workoutId, Workout work)
        {
            _workout.update(work);
            return CreatedAtAction("GetAllWorkouts", new { work });
        }
        [HttpDelete("{id}")]
        public ActionResult<Workout> DeleteWorkout(int id)
        { 
            _workout.delete(id);
            return Ok();
        }
    }
}