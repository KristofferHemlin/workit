using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WorkIT.Models;
using WorkIT.Repository;

namespace WorkIT.Controllers
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
        [HttpGet("{id}")]
        public ActionResult<Workout> GetWorkout(int id)
        {
            return _workout.getByID(id);
        }

        [HttpPost]
        public ActionResult AddWorkout(Workout work)
        {
            _workout.create(work);
            _workout.SaveChanges();
            return CreatedAtAction("GetAllWorkouts", new { id = work.workoutId });
                       
        }

        [HttpPut("{workoutId}")]
        public IActionResult UpdateWorkout(Workout work)
        {
            _workout.update(work);
            _workout.SaveChanges();
            return CreatedAtAction("GetAllWorkouts", new { work });
        }

        [HttpDelete("{id}")]
        public ActionResult<Workout> DeleteWorkout(int id)
        {
            if (id != 0)
            {
            _workout.delete(id);
            _workout.SaveChanges();
            return Ok();
            }
            return NotFound();
        }
    }
}
