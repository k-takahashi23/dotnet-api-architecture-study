using ApiArchitectureSample.Infrastructure.Repositories;

namespace ApiArchitectureSample.Application.Services
{
    public class HelloService : IHelloService
    {
        private IUserRepository _userRepository;

        public HelloService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public string GetHelloStringByUserId(int userId)
        {
            var user = _userRepository.GetById(userId);

            if (user == null)
            {
                return "This user does not exist!";
            }

            var helloString = $"Hello { user.Name }!";
            return helloString;
        }

        public string GetHelloStringByUserName(string userName)
        {
            if (userName == null)
            {
                return "Please give me your name...";
            }

            var helloString = $"Hello { userName }!";
            return helloString;
        }
    }
}
