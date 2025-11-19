using Microsoft.AspNetCore.Mvc;

namespace EtgBank.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountBalanceController : ControllerBase
    {
        [HttpPost]
        public IActionResult GetBalance([FromBody] object request)
        {
            throw new NotImplementedException();
        }
    }
}
