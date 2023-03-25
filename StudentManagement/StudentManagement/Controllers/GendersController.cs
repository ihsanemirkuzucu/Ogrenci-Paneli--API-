using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using StudentManagement.DomainModels;

namespace StudentManagement.Controllers
{
    [ApiController]
    public class GendersController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public GendersController(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllGendersAsync()
        {
            var genderList = await _studentRepository.GetGendersAsync();
            if(genderList == null || !genderList.Any()) 
            {
                return NotFound();
            }
            return Ok(_mapper.Map<List<Gender>>(genderList));
        }
    }
}
