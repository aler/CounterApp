using Microsoft.AspNetCore.Mvc;

namespace Signal.Web.Controllers
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
