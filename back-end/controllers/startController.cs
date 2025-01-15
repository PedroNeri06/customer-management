using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("[Controller]")]
public class StartController : ControllerBase
{
    [HttpGet]
    public IActionResult Start()
    {
        return Ok("oi");
    }

}