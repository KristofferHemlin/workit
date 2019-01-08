using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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
        public ActionResult AddWorkout(Workout work)
        {
            _context.Workout.Add(work);
            _context.SaveChanges();


            return Ok();
        }
    }
}