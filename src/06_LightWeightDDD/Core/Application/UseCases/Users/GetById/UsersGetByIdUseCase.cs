using ApiArchitectureSample.Application.Core.AggregateModels.UserAggregate;

namespace ApiArchitectureSample.Core.Application.UseCases.User
{
    public class UsersGetByIdUseCase : IUsersGetByIdUseCase
    {
        private IUserRepository _userRepository;

        public UsersGetByIdUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UsersGetByIdResponse Handle(UsersGetByIdRequest request)
        {
            var user = _userRepository.GetById(request.UserId);

            if (user == null) return null;

            return new UsersGetByIdResponse
            {
                Data = new UsersGetByIdResponseData
                {
                    UserName = user.Name,
                    Address = new UsersGetByIdResponseDataAddress
                    {
                        Street = user.Address.Street,
                        City = user.Address.City,
                        State = user.Address.State,
                        Country = user.Address.Country,
                        ZipCode = user.Address.ZipCode,
                    }
                }
            };
        }
    }
}
