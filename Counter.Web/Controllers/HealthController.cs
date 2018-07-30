using Microsoft.AspNetCore.Mvc;

namespace Counter.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return new EmptyResult();
        }
    }
}
