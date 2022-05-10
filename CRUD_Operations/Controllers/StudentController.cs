using CRUD_Operations.Models;
using CRUD_Operations.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Operations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        IStudentService _studentService;

        public StudentController(IStudentService service)
        {
            _studentService = service;
        }
        /// <summary>
        /// toti studentii
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        
        public IActionResult GetStudentsList()
        {
            try
            {
                var students = _studentService.GetStudentsList();
                if(students == null)
                    return NotFound();
                return Ok(students);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// lista studentulor dupa id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]/id")]
        public IActionResult GetStudentsById (int id)
        {
            try
            {
                var students = _studentService.GetStudentDetailsById(id);
                if (students == null)
                    return NotFound();
                return Ok(students);
            }catch (Exception)
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Salveaza student
        /// </summary>
        /// <param name="studentModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        public IActionResult SaveStudent(Student studentModel)
        {
            try
            {
                var model = _studentService.SaveStudent(studentModel);
                return Ok(model);
            }
            catch (Exception)
            {
                
                return BadRequest();
            }
        }
        /// <summary>
        /// eliminare student
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route ("[action]")]
        public IActionResult DeteleStudent(int id)
        {
            try
            {
                var model = _studentService.DeleteStudent(id);
                model.Message = "Studentul a fost eliminat cu succes";
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
