using Microsoft.AspNetCore.Mvc;

namespace EtgBank.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NameEnquiryController : ControllerBase
    {
        [HttpPost]
        public IActionResult Enquire([FromBody] object request)
        {
            throw new NotImplementedException();
        }
    }
}
