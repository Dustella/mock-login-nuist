using Microsoft.AspNetCore.Mvc;

namespace mock_login.Controllers;

[ApiController]
[Route("/api/v1")]
public class MainController : ControllerBase
{
    private readonly LoginService _loginService;

    public MainController(LoginService loginService)
    {
        _loginService = loginService;
    }
    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        // print request to console
        var result = _loginService.Login(request);

        return result ? Ok(_loginService.GetSuccessResponse()) : Ok(_loginService.GetErrorResponse());
    }

    [HttpGet("ip")]
    public IActionResult GetIp()
    {
        // print request to console
        return Ok(new { code = 200, data = Request.HttpContext.Connection.RemoteIpAddress?.ToString() });
    }
}
