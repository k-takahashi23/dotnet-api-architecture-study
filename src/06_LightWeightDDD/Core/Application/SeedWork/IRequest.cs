
namespace ApiArchitectureSample.Core.Application.SeedWork
{
    public interface IRequest<out TResponse> where TResponse : IResponse { }
}