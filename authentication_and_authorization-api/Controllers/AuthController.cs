using authentication_and_authorization_api.Interfaces;
using authentication_and_authorization_api.Models.Request.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace authentication_and_authorization_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [AllowAnonymous]
        [HttpGet("login")]
        public async Task<IActionResult> LoginAsync([FromBody]LoginRequest request)
        {

            return Ok();
        }
    }
}