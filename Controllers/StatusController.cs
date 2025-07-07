using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MyInitApi_6adb681ac5c44c3686fbe2f4d46f11f6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        public StatusController()
        {
        }

        // GET: api/status
        [HttpGet]
        public IActionResult GetStatus()
        {
            return Ok();
        }
    }
}
