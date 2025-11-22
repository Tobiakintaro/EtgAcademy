using Microsoft.AspNetCore.Mvc;

namespace EtgBank.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CreateAccountController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create([FromBody] object request)
        {
            throw new NotImplementedException();
        }
    }
}
