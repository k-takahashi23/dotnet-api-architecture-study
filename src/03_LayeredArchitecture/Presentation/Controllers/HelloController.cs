using System.Net.Mime;
using ApiArchitectureSample.Application.Services;
using ApiArchitectureSample.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiArchitectureSample.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces(MediaTypeNames.Application.Json)]
    public class HelloController
    {
        private IHelloService _helloService;

        public HelloController(IHelloService helloService)
        {
            _helloService = helloService;
        }

        [HttpGet]
        public IActionResult GetByUserName([FromQuery] HelloGetByUserNameRequest request)
        {
            var helloString = _helloService.GetHelloStringByUserName(request.UserName);

            var response = new HelloGetByUserNameResponse
            {
                Data = new HelloGetByUserNameResponseData
                {
                    Message = helloString
                }
            };

            return new JsonResult(response);
        }

        [HttpGet]
        [Route("{request.UserId}")]
        public IActionResult GetById([FromRoute] HelloGetByUserIdRequest request)
        {
            var helloString = _helloService.GetHelloStringByUserId(request.UserId);

            var response = new HelloGetByUserIdResponse
            {
                Data = new HelloGetByUserIdResponseData
                {
                    Message = helloString
                }
            };

            return new JsonResult(response);
        }
    }
}
