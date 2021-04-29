namespace ApiArchitectureSample.Core.Application.SeedWork
{
    public interface IUseCase<TRequest, TResponse>
        where TRequest : IRequest<IResponse>
        where TResponse : IResponse
    {
        TResponse Handle(TRequest request);
    }
}