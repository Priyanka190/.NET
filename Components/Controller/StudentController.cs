using Component.Model;
using Component.Repository;
using Component.Services;
using Component.StudentServices;
using Microsoft.AspNetCore.Mvc;


using Component.Model;
using Component.StudentServices;
using Microsoft.AspNetCore.Mvc;

namespace Component.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private IStudentServices studentServices;

        public StudentController(IStudentServices studentServices)
        {
            this.studentServices = studentServices;
        }


       [HttpPost("add")]
        public async Task<IActionResult> AddStudent(Student student)
        {
            var result = await studentServices.AddAsync(student);
            return Ok(result);
        }


       [HttpPost("GetAll")]
        public async Task<IActionResult> GetAllStudents()
        {
            var result = await studentServices.GetAllAsync();
            return Ok(result);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var removedstudent= await studentServices.DeleteAsync(id);
            return Ok(removedstudent);
        }
        [HttpPost("id")]
        public async Task<IActionResult?> GetByIdAsync(int id)
        {
            var result = studentServices.GetByIdAsync(id);
            return Ok(result);
        }
        [HttpPatch]
        public async Task<IActionResult> UpdateAsync(Student student)
        {
            var result = studentServices.UpdateAsync(student);
            return Ok(result);
        }
        
    }
}