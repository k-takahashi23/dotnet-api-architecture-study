using ApiArchitectureSample.Core.Application.SeedWork;

namespace ApiArchitectureSample.Core.Application.UseCases.Hello
{
    public interface IHelloGetByUserNameUseCase :
        IUseCase<HelloGetByUserNameRequest, HelloGetByUserNameResponse>
    { }
}
