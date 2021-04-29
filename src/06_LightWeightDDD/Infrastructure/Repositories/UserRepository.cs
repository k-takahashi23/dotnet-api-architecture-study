using ApiArchitectureSample.Application.Core.AggregateModels.UserAggregate;
using System.Collections.Generic;
using System.Linq;

namespace ApiArchitectureSample.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private ApiArchitectureSampleContext _dbContext;
        public UserRepository(ApiArchitectureSampleContext dbContext)
        {
            _dbContext = dbContext;
        }

        public User GetById(int userId)
        {
            var user = _dbContext.Users
                .Where(u => u.Id == userId)
                .FirstOrDefault();

            return user;
        }

        public User GetByName(string userName)
        {
            var user = _dbContext.Users
                .Where(u => u.Name == userName)
                .FirstOrDefault();

            return user;
        }

        public List<User> FindAll() => _dbContext.Users.ToList();
    }
}
