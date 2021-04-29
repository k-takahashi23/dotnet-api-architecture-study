namespace ApiArchitectureSample.PrimaryPorts
{
    public interface IHelloService
    {
        string GetHelloStringByUserId(int userId);

        string GetHelloStringByUserName(string userName);
    }
}
