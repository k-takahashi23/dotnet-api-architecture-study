using System.ComponentModel.DataAnnotations;

namespace ApiArchitectureSample.Presentation.Models
{
    public class HelloGetByUserIdRequest
    {
        [Required]
        public int UserId { get; set; }
    }
}
