using System.ComponentModel.DataAnnotations;

namespace ApiArchitectureSample.Core.Application.UseCases.Hello
{
    public class HelloGetByUserNameRequest
    {
        [Required]
        public string UserName { get; set; }
    }
}
