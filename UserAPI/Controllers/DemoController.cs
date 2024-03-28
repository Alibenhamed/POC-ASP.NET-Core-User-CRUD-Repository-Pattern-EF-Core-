

namespace UserAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DemoController : ControllerBase
{
    [HttpGet]
    public string Greetings()
    {
        return "Hello trend-it";
    }
}

