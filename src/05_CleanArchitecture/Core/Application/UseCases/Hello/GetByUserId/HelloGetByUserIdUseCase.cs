using ApiArchitectureSample.Application.Core.Models;

namespace ApiArchitectureSample.Core.Application.UseCases.Hello
{
    public class HelloGetByUserIdUseCase : IHelloGetByUserIdUseCase
    {
        private IUserRepository _userRepository;

        public HelloGetByUserIdUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public HelloGetByUserIdResponse Handle(HelloGetByUserIdRequest request)
        {
            var user = _userRepository.GetById(request.UserId);

            if (user == null)
            {
                return new HelloGetByUserIdResponse
                {
                    Data = new HelloGetByUserIdResponseData
                    {
                        Message = "This user does not exist!"
                    }
                };
            }

            return new HelloGetByUserIdResponse
            {
                Data = new HelloGetByUserIdResponseData
                {
                    Message = $"Hello { user.Name }!"
                }
            };
        }
    }
}
