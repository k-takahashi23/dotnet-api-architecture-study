using ApiArchitectureSample.Application.Core.AggregateModels.UserAggregate;

namespace ApiArchitectureSample.Core.Application.UseCases.Hello
{
    public class HelloGetByUserNameUseCase : IHelloGetByUserNameUseCase
    {
        private IUserRepository _userRepository;

        public HelloGetByUserNameUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public HelloGetByUserNameResponse Handle(HelloGetByUserNameRequest request)
        {
            if (string.IsNullOrEmpty(request.UserName))
            {
                return new HelloGetByUserNameResponse
                {
                    Data = new HelloGetByUserNameResponseData
                    {
                        Message = "Please give me your name..."
                    }
                };
            }

            return new HelloGetByUserNameResponse
            {
                Data = new HelloGetByUserNameResponseData
                {
                    Message = $"Hello { request.UserName }!"
                }
            };
        }
    }
}
