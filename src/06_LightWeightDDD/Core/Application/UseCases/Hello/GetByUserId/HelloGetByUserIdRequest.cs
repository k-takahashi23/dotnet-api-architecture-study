using System.ComponentModel.DataAnnotations;
using ApiArchitectureSample.Core.Application.SeedWork;

namespace ApiArchitectureSample.Core.Application.UseCases.Hello
{
    public class HelloGetByUserIdRequest : IRequest<HelloGetByUserIdResponse>
    {
        [Required]
        public int UserId { get; set; }
    }
}
