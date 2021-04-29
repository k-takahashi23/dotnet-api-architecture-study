namespace ApiArchitectureSample.Application.Services
{
    public interface IHelloService
    {
        string GetHelloStringByUserId(int userId);

        string GetHelloStringByUserName(string userName);
    }
}
