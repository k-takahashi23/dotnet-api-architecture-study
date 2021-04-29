namespace ApiArchitectureSample.Repositories
{
    public interface IUserRepository
    {
        User GetById(int id);

        User GetByName(string userName);
    }
}
