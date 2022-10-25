using Microsoft.AspNetCore.Mvc;

namespace TaskManager.Controllers
{
    [ApiController]
    [Route("[api/controller]")]
    public class LoginController : ControllerBase
    {
       private readonly ILogger<LoginController> _logger;
       
        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult EfectuarLogin([FromBody] )
        {

        }
    }
}
