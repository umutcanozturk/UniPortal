using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebProgramlamaOdev.Core.Interfaces;
using WebProgramlamaOdev.Core.Models;

namespace WebProgramlamaOdev.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly ILoginRepository _repository;
        public LoginController(ILoginRepository repository)
        {
            _repository = repository;
        }
        [HttpPost]
        [Route("Register")]
        public void Register([FromBody]LoginModel entity)
        {
            _repository.Create(entity);
        }
        [HttpGet] 
        [Route("Validate")]
        public async Task<bool> Validate(string mail,string pw)
        {
            return await _repository.Validate(mail, pw);   
        }
    }
}
