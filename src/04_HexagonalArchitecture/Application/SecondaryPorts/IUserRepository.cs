using ApiArchitectureSample.Application.Core.Models;

namespace ApiArchitectureSample.Application.Core.SecondaryPorts
{
    public interface IUserRepository
    {
        User GetById(int id);

        User GetByName(string userName);
    }
}
