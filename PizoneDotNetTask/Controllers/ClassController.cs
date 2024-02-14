
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizoneDotNetTask.Data;
using PizoneDotNetTask.Model;
using System.Security.Claims;

namespace PizoneDotNetTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly DataContext _context;
        public ClassController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<ClassController>>> GetAllClasses()
        {
            return await _context.GetAllClasses();
            //var result = _context.Classes.ToList();
            //return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClassController>> GetSingleClass(int id)
        {
            var result = await _context.GetSingleClass(id);
            if (result is null)
                return NotFound("Hero not found.");

            return Ok(result);
        }


        [HttpGet("GetAllClassBySchoolId")]
        public async Task<ActionResult<ClassController>> GetAllClassBySchoolId(int schoolId)
        {
            var result = _context.Schools.FirstOrDefault();
            if (result is null)
            {
                return NotFound("Class You are searching for not found!");
            }
            return Ok(result);
        }


        [HttpPost]
        public Task<ActionResult<List<ClassController>>> AddClass(ClassModel classes)
        {
            _context.Classes.Add(classes);
            _context.SaveChanges();
            return Ok(classes);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<List<ClassController>>> UpdateClass(int id, ClassController request)
        {
            var result = await _context.UpdateClass.(id, request);

            if (result is null)
                return NotFound("Class not found.");

            return Ok(result);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<List<ClassController>>> DeleteClass(int id)
        {
            var result = _context.Classes.Find(id);
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




