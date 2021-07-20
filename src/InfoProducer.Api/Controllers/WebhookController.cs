using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace InfoProducer.Api.Comtrollers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class WebhookController : ControllerBase
    {
        private readonly ILogger _logger;

        public WebhookController(ILogger<WebhookController> logger)
        {
            _logger = logger;
        }
    }
}