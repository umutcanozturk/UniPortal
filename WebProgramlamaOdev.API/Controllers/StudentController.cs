using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;
using WebProgramlamaOdev.Core.Interfaces;
using WebProgramlamaOdev.Core.Models;

namespace WebProgramlamaOdev.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : Controller
    {
        private readonly IStudentRepository _repository;
        public StudentController(IStudentRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        [Route("GetAll")]
       public string GetAll()
        {
            var list =  _repository.GetAll().ToList();
            return JsonConvert.SerializeObject(list);
        }
        [HttpGet]
        [Route("Delete")]
        public async Task Delete( int id)
        {
           await _repository.Delete(id);
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public async Task<Student> GetByIdAsync(int id)
        {
            return await _repository.GetById(id);
        }
        [HttpPost]
        [Route("Update")]
        public async Task Update([FromBody]Student student)
        {
           
            await  _repository.Update(student);
        }
        [HttpPost]
        [Route("Add")]
        public async Task Add([FromBody] Student student)
        {

            await _repository.Create(student);
        }

    }
}
