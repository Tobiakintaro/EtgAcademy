using Microsoft.AspNetCore.Mvc;

namespace EtgBank.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FundTransferController : ControllerBase
    {
        [HttpPost]
        public IActionResult Transfer([FromBody] object request)
        {

        }
    }
}
