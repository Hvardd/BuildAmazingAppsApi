using AutoMapper;
using BuildAmazingAppsApi.DomainModels;
using BuildAmazingAppsApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BuildAmazingAppsApi.Controllers
{
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;

        public StudentsController(IStudentRepository studentRepository, IMapper mapper)
        {
            this.studentRepository = studentRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllStudents()
        {
           var students = await studentRepository.GetStudentsAsync();
 
            return Ok(mapper.Map<List<Student>>(students));

         }
        [HttpGet]
        [Route("[controller]/{studentId:guid}")]
        public async Task<IActionResult> GetStudentAsync([FromRoute] Guid studentId)
        {
            // Fetch Student Details 
            var student = await studentRepository.GetStudentAsync(studentId);
            // Return Student
            if (student == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<Student>(student));
        }
    }
}
