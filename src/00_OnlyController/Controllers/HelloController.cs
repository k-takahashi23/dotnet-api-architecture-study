using Microsoft.AspNetCore.Mvc;

namespace ApiArchitectureSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController
    {
        public HelloController() { }

        [HttpGet]
        public string Get()
        {
            var response = "Hello world!";
            return response;
        }
    }
}
