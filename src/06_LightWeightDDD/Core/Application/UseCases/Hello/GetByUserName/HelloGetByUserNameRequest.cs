using System.ComponentModel.DataAnnotations;
using ApiArchitectureSample.Core.Application.SeedWork;

namespace ApiArchitectureSample.Core.Application.UseCases.Hello
{
    public class HelloGetByUserNameRequest : IRequest<HelloGetByUserNameResponse>
    {
        [Required]
        public string UserName { get; set; }
    }
}
