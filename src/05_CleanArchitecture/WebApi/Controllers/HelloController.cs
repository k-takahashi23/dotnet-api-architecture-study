using ApiArchitectureSample.Core.Application.UseCases.Hello;
using Microsoft.AspNetCore.Mvc;

namespace ApiArchitectureSample.WebApi.Controllers
{
    public class HelloController : ApiControllerBase
    {
        private IHelloGetByUserNameUseCase _helloGetByUserNameUseCase;

        private IHelloGetByUserIdUseCase _helloGetByUserIdUseCase;

        public HelloController(
            IHelloGetByUserNameUseCase helloGetByUserNameUseCase,
            IHelloGetByUserIdUseCase helloGetByUserIdUseCase)
        {
            _helloGetByUserNameUseCase = helloGetByUserNameUseCase;
            _helloGetByUserIdUseCase = helloGetByUserIdUseCase;
        }

        [HttpGet]
        public IActionResult GetByUserName([FromQuery] HelloGetByUserNameRequest request)
        {
            var response = _helloGetByUserNameUseCase.Handle(request);

            return new JsonResult(response);
        }

        [HttpGet]
        [Route("{request.UserId}")]
        public IActionResult GetById([FromRoute] HelloGetByUserIdRequest request)
        {
            var response = _helloGetByUserIdUseCase.Handle(request);

            return new JsonResult(response);
        }
    }
}
