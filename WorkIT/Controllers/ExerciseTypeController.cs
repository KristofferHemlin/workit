using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WorkIT.Data;
using WorkIT.Models;
using WorkIT.Repository;

namespace WorkIT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseTypeController : ControllerBase
    {
        private readonly IRepository<ExerciseType> _exerciseType;

        public ExerciseTypeController(IRepository<ExerciseType> exerciseType)
        {
            _exerciseType = exerciseType;
        }
       

        [HttpGet]
        public IEnumerable<ExerciseType> GetAllExerciseTypes()
        {
            return _exerciseType.get();
        }
      
    }
}