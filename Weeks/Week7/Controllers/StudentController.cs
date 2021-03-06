using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Database;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly SchoolContext _dbContext;

        public StudentController(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<List<Product>> GetAllProducts()
        {
            var result = _dbContext.Product.ToList();
            return Ok(result);
        }

        [HttpGet("{studentId}")]
        public ActionResult<Student> GetStudent(int studentId)
        {
            var student = _dbContext.Student
                .SingleOrDefault(p => p.StudentId == studentId);

            if (student != null) {
                return student;
            } else {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<Student> AddStudent(Student student)
        {
            _dbContext.Student.Add(student);
            _dbContext.SaveChanges();

            // return CreatedAtAction(nameof(GetProduct), new { id = product.ProductId }, product);

            return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status201Created);
        }

        [HttpDelete("{studentId}")]
        public ActionResult DeleteStudent(int studentId)
        {
            var student = new Student { StudentId = studentId };

            _dbContext.Student.Attach(student);
            _dbContext.Student.Remove(student);
            _dbContext.SaveChanges();

            return Ok();
        }

        [HttpPut("{studentId}")]
        public ActionResult UpdateStudent(int studentId, Student studentUpdate)
        {
            var student = _dbContext.Student
                .SingleOrDefault(p => p.StudentId == studentId);

            if (student != null)
            {
                student.Name = studentUpdate.Name;
                student.Price = studentUpdate.Price;
                student.Count = studentUpdate.Count;

                _dbContext.Update(student);

                _dbContext.SaveChanges();
            }

            return NoContent();
        }
    }
}