using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace mtnmomotest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReconcileController : ControllerBase
    {
        ILogger<ReconcileController> logger;

        public ReconcileController(ILogger<ReconcileController> logger)
        {
                this.logger = logger;
        }

        [HttpPost]
        [Route("/Reconcile")]
        public IActionResult ReconcileCallback(JsonDocument obj)
        {

            string data  = obj.RootElement.ToString();

            logger.LogInformation($"This is the data from the callback {data}");

            return Ok(obj);
        }
    }
}
