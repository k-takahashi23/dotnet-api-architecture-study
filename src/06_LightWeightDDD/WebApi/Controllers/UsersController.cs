using ApiArchitectureSample.Core.Application.UseCases.User;
using Microsoft.AspNetCore.Mvc;

namespace ApiArchitectureSample.WebApi.Controllers
{
    public class UsersController : ApiControllerBase
    {
        private IUsersFindAllUseCase _usersFindAllUseCase;

        private IUsersGetByIdUseCase _usersGetByIdUseCase;

        public UsersController(
            IUsersFindAllUseCase usersFindAllUseCase,
            IUsersGetByIdUseCase usersGetByIdUseCase)
        {
            _usersFindAllUseCase = usersFindAllUseCase;
            _usersGetByIdUseCase = usersGetByIdUseCase;
        }

        [HttpGet]
        [Route("")]
        public IActionResult FindAll([FromQuery] UsersFindAllRequest request)
        {
            var response = _usersFindAllUseCase.Handle(request);

            if (response == null) return BadRequest();

            return Ok(response);
        }

        [HttpGet]
        [Route("{request.UserId}")]
        public IActionResult GetById([FromRoute] UsersGetByIdRequest request)
        {
            var response = _usersGetByIdUseCase.Handle(request);

            if (response == null) return BadRequest();

            return Ok(response);
        }
    }
}
