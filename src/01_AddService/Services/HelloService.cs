namespace ApiArchitectureSample.Services
{
    public class HelloService : IHelloService
    {
        public HelloService() { }

        public string GetHelloString(string userName)
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
