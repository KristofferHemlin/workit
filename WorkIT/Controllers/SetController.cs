using Microsoft.AspNetCore.Mvc;
using WorkIT.Data;

namespace WorkIT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SetController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SetController(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}