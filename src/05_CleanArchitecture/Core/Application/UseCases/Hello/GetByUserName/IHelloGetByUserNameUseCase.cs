namespace ApiArchitectureSample.Core.Application.UseCases.Hello
{
    public interface IHelloGetByUserNameUseCase
    {
        HelloGetByUserNameResponse Handle(HelloGetByUserNameRequest request);
    }
}
