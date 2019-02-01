using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    }
}