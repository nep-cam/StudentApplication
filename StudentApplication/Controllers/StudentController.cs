using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentApplication.Dto.Student;
using StudentApplication.Entity;

namespace StudentApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private static List<Student> _students = new List<Student>();
        private static int _id = 0;

        [HttpPost("create")]
        public IActionResult CreateStudent(CreateStudentDto input)
        {
            try
            {
                
                
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });

                
            }
        }

        [HttpPut("update/{id}")]
        public IActionResult UpdateStudent(int id, UpdateStudentDto input)
        {
            try
            {
                var studentFind = _students.FirstOrDefault(s => s.Id == id);
                if (studentFind == null)
                {
                    return NotFound(new { message = $"Không tìm thấy student có Id = {id}" });
                }
                studentFind.Name = input.Name;
                studentFind.StudentCode = input.StudentCode;
                studentFind.DateOfBirth = input.DateOfBirth;
                return Ok();
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
            
        }

        [HttpGet("get-by-id/{id}")]
        public IActionResult GetById(int id)
        {
            var studentFind = _students.FirstOrDefault(s => s.Id == id);
            if (studentFind == null) 
            {
                return NotFound(new { message = $"Không tìm thấy user có Id = {id}" });
            }
            return Ok(studentFind);
        }

     
        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            return Ok(_students);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var studentFind = _students.FirstOrDefault(s => s.Id == id);
                if (studentFind == null)
                {
                    return NotFound(new { message = $"Không tìm thấy student có Id = {id}" });
                }
                _students.Remove(studentFind);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
        }
    }
}
