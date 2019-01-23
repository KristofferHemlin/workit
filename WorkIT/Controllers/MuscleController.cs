using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WorkIT.Models;
using WorkIT.Repository;

namespace WorkIT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MuscleController : ControllerBase
    {
        private readonly IRepository<Muscle> _muscle;

        public MuscleController(IRepository<Muscle> muscle)
        {
            _muscle = muscle;
        }

        [HttpGet]
        public IEnumerable<Muscle> GetMuscles()
        {
            return _muscle.get();
        }
    }
}