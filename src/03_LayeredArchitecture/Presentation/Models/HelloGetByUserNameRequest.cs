using System.ComponentModel.DataAnnotations;

namespace ApiArchitectureSample.Presentation.Models
{
    public class HelloGetByUserNameRequest
    {
        [Required]
        public string UserName { get; set; }
    }
}
