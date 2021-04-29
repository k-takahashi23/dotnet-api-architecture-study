using System.ComponentModel.DataAnnotations;

namespace ApiArchitectureSample.PrimaryAdapters.WebApi.Models
{
    public class HelloGetByUserIdRequest
    {
        [Required]
        public int UserId { get; set; }
    }
}
