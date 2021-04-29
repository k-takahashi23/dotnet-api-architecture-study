using System.ComponentModel.DataAnnotations;

namespace ApiArchitectureSample.Core.Application.UseCases.Hello
{
    public class HelloGetByUserIdRequest
    {
        [Required]
        public int UserId { get; set; }
    }
}
