namespace ApiArchitectureSample.Application.Core.Models
{
    public interface IUserRepository
    {
        User GetById(int id);

        User GetByName(string userName);
    }
}
