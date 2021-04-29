using ApiArchitectureSample.Core.Application.SeedWork;

namespace ApiArchitectureSample.Core.Application.UseCases.User
{
    public interface IUsersGetByIdUseCase :
        IUseCase<UsersGetByIdRequest, UsersGetByIdResponse>
    { }
}
