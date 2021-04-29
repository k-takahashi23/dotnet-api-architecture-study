using ApiArchitectureSample.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiArchitectureSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController
    {
        private IHelloService _helloService;

        public HelloController(IHelloService helloService)
        {
            _helloService = helloService;
        }

        [HttpGet]
        public string GetByUserName(string userName)
        {
            var helloString = _helloService.GetHelloStringByUserName(userName);
            return helloString;
        }

        [HttpGet]
        [Route("{userId}")]
        public string GetById(int? userId)
        {
            if (userId == null)
            {
                return "Please give me your id...";
            }
            var helloString = _helloService.GetHelloStringByUserId((int)userId);
            return helloString;
        }
    }
}
