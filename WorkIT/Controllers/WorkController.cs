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

        [HttpPost]
        public ActionResult AddWorkout(Workout work)
        {
            _workout.create(work);
            _workout.SaveChanges();

            return CreatedAtAction("GetAllWorkouts", new { id = work.workoutId });      
        }
        [HttpDelete("{id}")]
        public ActionResult<Workout> DeleteWorkout(int id)
        { 
            _workout.delete(id);
            return Ok();
        }
    }
}