using Microsoft.AspNetCore.Mvc;

namespace EtgBank.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TSQController : ControllerBase
    {
        [HttpPost]
        public IActionResult TransactionQuery([FromBody] object request)
        {
            throw new NotImplementedExceptio();
        }
    }
}
 