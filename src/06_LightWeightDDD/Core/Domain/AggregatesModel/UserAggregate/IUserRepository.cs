using System.Collections.Generic;
using ApiArchitectureSample.Core.Domain.SeedWork;

namespace ApiArchitectureSample.Application.Core.AggregateModels.UserAggregate
{
    public interface IUserRepository : IRepository<User>
    {
        User GetById(int userId);

        User GetByName(string userName);

        List<User> FindAll();
    }
}
