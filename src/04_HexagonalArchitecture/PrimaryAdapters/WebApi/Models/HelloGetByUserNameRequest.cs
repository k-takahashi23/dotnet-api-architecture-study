using System.ComponentModel.DataAnnotations;

namespace ApiArchitectureSample.PrimaryAdapters.WebApi.Models
{
    public class HelloGetByUserNameRequest
    {
        [Required]
        public string UserName { get; set; }
    }
}
