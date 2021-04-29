using ApiArchitectureSample.Core.Application.SeedWork;

namespace ApiArchitectureSample.Core.Application.UseCases.Hello
{
    public interface IHelloGetByUserIdUseCase :
        IUseCase<HelloGetByUserIdRequest, HelloGetByUserIdResponse>
    { }
}
