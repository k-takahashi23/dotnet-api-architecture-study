using System.ComponentModel.DataAnnotations;
using ApiArchitectureSample.Core.Application.SeedWork;

namespace ApiArchitectureSample.Core.Application.UseCases.User
{
    public class UsersGetByIdRequest : IRequest<UsersGetByIdResponse>
    {
        [Required]
        public int UserId { get; set; }
    }
}
