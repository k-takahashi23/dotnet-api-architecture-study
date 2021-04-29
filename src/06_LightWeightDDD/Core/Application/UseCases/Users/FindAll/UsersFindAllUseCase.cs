using System.Linq;
using ApiArchitectureSample.Application.Core.AggregateModels.UserAggregate;

namespace ApiArchitectureSample.Core.Application.UseCases.User
{
    public class UsersFindAllUseCase : IUsersFindAllUseCase
    {
        private IUserRepository _userRepository;

        public UsersFindAllUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UsersFindAllResponse Handle(UsersFindAllRequest request)
        {
            var users = _userRepository.FindAll();

            if (users == null || users.Count == 0) return null;

            return new UsersFindAllResponse
            {
                Data = new UsersFindAllResponseData
                {
                    Count = users.Count,
                    Users = users.Select(u => new UsersFindAllResponseDataUser
                    {
                        UserId = u.Id,
                        UserName = u.Name
                    }).ToList()
                }
            };
        }
    }
}
