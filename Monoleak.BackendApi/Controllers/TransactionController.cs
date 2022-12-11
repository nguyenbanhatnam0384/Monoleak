using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Monoleak.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Test ok");
        }
    }
}
