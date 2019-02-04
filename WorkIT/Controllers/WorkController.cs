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
            //_workout.SaveChanges();
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

//public override async Task UpdateAsync(NewsUpdateDto dto)
//{
//    var error = Validate(dto);
//    if (!string.IsNullOrWhiteSpace(error.Message)) throw new AppGuiException(error.Message, error.ClientMessage);

//    Check previous realestate and create or delete depending on actual status
//   var previousItems = await realEstateSvc.GetAsync(x => x.NewsID == dto.ID);
//    var itemsToCreate = dto.RealEstates.Where(x => x.ID.IsEmpty());
//    var itemsToDelete = previousItems.Where(x => !dto.RealEstates.Select(y => y.ID).Contains(x.ID));
//    var tasks = new List<Task>();
//    foreach (var item in itemsToCreate)
//    {
//        item.NewsID = dto.ID;
//        tasks.Add(realEstateSvc.CreateAsync(item));
//    }
//    foreach (var item in itemsToDelete)
//    {
//        tasks.Add(realEstateSvc.DeleteAsync(item.ID));
//    }

//    await base.UpdateAsync(dto);
//}