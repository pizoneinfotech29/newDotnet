using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizoneDotNetTask.Data;

namespace PizoneDotNetTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly DataContext _context;
        public SchoolController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<ClassController>>> GetAllSchool()
        {
            return await _context.GetAllSchool();
            //var result = _context.Classes.ToList();
            //return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SchoolController>> GetSingleSchool(int id)
        {
            var result = await _context.GetSingleSchool(id);
            if (result is null)
                return NotFound("Hero not found.");

            return Ok(result);
        }

        [HttpPost]
        public Task<ActionResult<List<ClassController>>> AddClass(ClassModel School)
        {
            _context.Classes.Add(School);
            _context.SaveChanges();
            return Ok(School);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<List<SchoolController>>> UpdateSchool(int id, SchoolController request)
        {
            var result = await _context.UpdateSchool.(id, request);

            if (result is null)
                return NotFound("Class not found.");

            return Ok(result);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SchoolController>>> DeleteSchool(int id)
        {
            var result = _context.Schools.Find(id);
            if (result is null)
            {
                return NotFound("The class You are Looking for Not found!");
            }
            _context.Classes.Remove(result);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
