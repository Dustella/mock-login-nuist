using Microsoft.AspNetCore.Mvc;

namespace mock_login.Controllers;

[ApiController]
[Route("/api/v1")]
public class MainController : ControllerBase
{
    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        // print request to console
        Console.WriteLine(request.Username);
        // return a 200 response
        return Ok();
    }
}
