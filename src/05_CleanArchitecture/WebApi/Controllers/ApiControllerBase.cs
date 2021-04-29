using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;

namespace ApiArchitectureSample.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces(MediaTypeNames.Application.Json)]
    public abstract class ApiControllerBase
    {
    }
}
