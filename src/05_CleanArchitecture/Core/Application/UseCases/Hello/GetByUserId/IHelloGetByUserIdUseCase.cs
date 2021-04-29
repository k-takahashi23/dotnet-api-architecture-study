namespace ApiArchitectureSample.Core.Application.UseCases.Hello
{
    public interface IHelloGetByUserIdUseCase
    {
        HelloGetByUserIdResponse Handle(HelloGetByUserIdRequest request);
    }
}
