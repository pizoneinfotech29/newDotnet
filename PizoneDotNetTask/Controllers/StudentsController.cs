using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizoneDotNetTask.Data;

namespace PizoneDotNetTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly DataContext _context;
        public StudentsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var result = _context.Schools.ToList();
            return Ok(result);
        }
    }
}
