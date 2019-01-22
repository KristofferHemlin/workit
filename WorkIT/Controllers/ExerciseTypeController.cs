using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        //private readonly ApplicationDbContext _context;

        //public ExerciseTypeController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}


        [HttpGet]
        public IEnumerable<ExerciseType> GetAllExerciseTypes()
        {
            return _exerciseType.get();
            //return _context.ExerciseType.ToList();
        }
    }
}