using Microsoft.AspNetCore.Mvc;

namespace C4M.Api.Infrastructure
{
    [ApiController]
    [Route("v{version:apiVersion}/[controller]")]
    public abstract class ControllerBaseApi : ControllerBase
    {
    }
}
