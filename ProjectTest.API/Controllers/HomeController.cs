using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProjectTest.API.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            _logger.LogInformation("Initial Home Get");
            return "Net Core 5.0 Running ... 1503022-v5.0.4 CI/CD from JENKINS FILE in AKS v5.0.0 AFORO255";
        }
    }
}
