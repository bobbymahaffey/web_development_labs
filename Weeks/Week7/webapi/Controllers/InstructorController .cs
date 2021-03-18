using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Database;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InstructorController : ControllerBase
    {
        private readonly ILogger<InstructorController> _logger;

        public InstructorController(ILogger<InstructorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(getInstructors());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            
            var instructor = InMemory.Instructors.FirstOrDefault(s => s.Id == id);

            if (instructor == null)
            {
                return NotFound();
            }

            return Ok(instructor);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Instructor instructor)
        {
            instructor.Id = getNextId();

            InMemory.Instructors.Add(instructor);

            return CreatedAtAction(nameof(GetById), new { id = instructor.Id }, instructor);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateInstructor(int id, [FromBody] Instructor instructor)
        {
            var existingInstructor = InMemory.Instructors.FirstOrDefault(s => s.Id == id);

            if (existingInstructor == null)
            {
                return NotFound();
            }

            existingInstructor.FirstName = instructor.FirstName;
            existingInstructor.LastName = instructor.LastName;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteInstructor(int id)
        {
            var existingInstructor = InMemory.Instructors.FirstOrDefault(s => s.Id == id);

            if (existingInstructor == null)
            {
                return NotFound();
            }

            InMemory.Instructors.Remove(existingInstructor);

            return NoContent();
        }

        private List<Instructor> getInstructors()
        {
            return InMemory.Instructors;
        }  

        private int getNextId()
        {
            return InMemory.Instructors.Max(p => p.Id) + 1;
        }
    }
}