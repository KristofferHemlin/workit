using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WorkIT.Models;
using WorkIT.Repository;

namespace WorkIT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SetController : ControllerBase
    {
        private readonly IRepository<Set> _set;

        public SetController(IRepository<Set> set)
        {
            _set = set;
        }

        [HttpDelete("{id}")]
        public ActionResult<Set> DeleteSet(int id)
        {
            if (id != 0)
            {
                _set.delete(id);
                _set.SaveChanges();
                return Ok();
            }
            return NotFound();
        }
        [HttpGet]
        public IEnumerable<Set> GetAllSets()
        {
            return _set.get();

        }

        [HttpPut("{id}")]
        public IActionResult UpdateWorkout(Set set)
        {
            _set.update(set);
            _set.SaveChanges();
            return CreatedAtAction("GetAllSets", new { set });
        }

        [HttpPost]
        public ActionResult AddSet(Set set)
        {
            _set.create(set);
            _set.SaveChanges();
            return CreatedAtAction("GetAllWorkouts", new { id = set.setId });

        }
    }
}