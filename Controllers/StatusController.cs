using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Genapi_37e044ae_b317_4a3b_9cde_fbaee5205681.Controllers
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
