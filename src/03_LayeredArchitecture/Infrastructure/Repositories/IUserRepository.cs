using ApiArchitectureSample.Domain.Models;

namespace ApiArchitectureSample.Infrastructure.Repositories
{
    public interface IUserRepository
    {
        User GetById(int id);

        User GetByName(string userName);
    }
}
