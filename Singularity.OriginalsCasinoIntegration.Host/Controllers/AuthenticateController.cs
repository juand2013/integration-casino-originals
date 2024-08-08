using Microsoft.AspNetCore.Mvc;

namespace Singularity.OriginalsCasinoIntegration.Host.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticateController : ControllerBase
    {
        private readonly ILogger<AuthenticateController> _logger;

        public AuthenticateController(ILogger<AuthenticateController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public IEnumerable<AuthenticateResponse> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new AuthenticateResponse()).ToArray();
        }
    }
}
