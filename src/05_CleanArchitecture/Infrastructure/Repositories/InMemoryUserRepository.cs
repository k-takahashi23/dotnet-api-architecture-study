using System.Collections.Generic;
using System.Linq;
using ApiArchitectureSample.Application.Core.Models;

namespace ApiArchitectureSample.Infrastructure.Repositories
{
    public class InMemoryUserRepository : IUserRepository
    {
        public InMemoryUserRepository() { }

        public User GetById(int userId)
        {
            var user = Users()
                .Where(u => u.Id == userId)
                .FirstOrDefault();

            return user;
        }

        public User GetByName(string userName)
        {
            var user = Users()
                .Where(u => u.Name == userName)
                .FirstOrDefault();

            return user;
        }

        private List<User> Users()
        {
            return new List<User>
            {
                new User
                {
                    Id = 1,
                    Name = "Tanaka Ichiro"
                },
                new User
                {
                    Id = 2,
                    Name = "Tanaka Jiro"
                },
                new User
                {
                    Id = 3,
                    Name = "Tanaka Saburo"
                }
            };
        }
    }
}
