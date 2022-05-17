using AutoMapper;
using BuildAmazingAppsApi.DomainModels;
using BuildAmazingAppsApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BuildAmazingAppsApi.Controllers
{
    [ApiController]
    public class GendersController : Controller
    {
        private readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;

        public GendersController(IStudentRepository studentRepository, IMapper mapper)
        {
            this.studentRepository = studentRepository;
            this.mapper = mapper;
        }


        [HttpGet]
        [Route("[controller]")]
        public async Task <IActionResult> GetAllGenders()
        {
            var genderList = await studentRepository.GetGendersAsync();

            if (genderList == null || !genderList.Any())
            {
                return NotFound();
            }
            return Ok(mapper.Map<List<Gender>>(genderList));
        }
    }
}
