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
        public string Get(string userName)
        {
            var helloString = _helloService.GetHelloString(userName);
            return helloString;
        }
    }
}
