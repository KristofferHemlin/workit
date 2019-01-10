using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkIT.Data;
using WorkIT.Models;

namespace WorkIT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseTypeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ExerciseTypeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ExerciseType>> GetAllExerciseTypes()
        {
            return _context.ExerciseType;
        }

    }
}