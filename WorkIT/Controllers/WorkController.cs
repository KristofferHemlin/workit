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
       

        public WorkController(IRepository<Workout> workout)
        {
            _workout = workout;
        }

        [HttpGet]
        public IEnumerable<Workout> GetAllWorkouts()
        {
            return _workout.get();

        }

        [HttpPost]
        public ActionResult AddWorkout(Workout work)
        {
            _workout.create(work);
            _workout.SaveChanges();

            return CreatedAtAction("GetAllWorkouts", new { id = work.workoutId });      
        }

        [HttpPut("{workoutId}")]
        public IActionResult UpdateWorkout(long workoutId, Workout work)
        {
            _workout.update(work);
            _workout.SaveChanges();
            return CreatedAtAction("GetAllWorkouts", new { work });
        }

        [HttpDelete("{id}")]
        public ActionResult<Workout> DeleteWorkout(int id)
        { 
            _workout.delete(id);
            _workout.SaveChanges();
            return Ok();
        }
    }
}