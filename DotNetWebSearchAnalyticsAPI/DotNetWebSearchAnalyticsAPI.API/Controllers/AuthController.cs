using DotNetWebSearchAnalyticsAPI.Api.Services;
using DotNetWebSearchAnalyticsAPI.Shared;
using Microsoft.AspNetCore.Mvc;

namespace DotNetWebSearchAnalyticsAPI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private UserService _UserService;

        public AuthController(UserService prUserService)
        {
            _UserService = prUserService;
        }

        // /api/auth/register
        [HttpPost("Register")]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterViewModel prModel)
        {
            if (ModelState.IsValid)
            {
                var lResult = await _UserService.RegisterUserAsync(prModel);

                if (lResult.isSuccess)
                    return Ok(lResult); // Status Code: 200

                return BadRequest(lResult);
            }

            return BadRequest("Some properties are not valid"); // Status Code: 400
        }

        // /api/auth/login
        [HttpPost("Login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginViewModel prModel)
        {
            if (ModelState.IsValid)
            {
                var lResult = await _UserService.LoginUserAsync(prModel);

                if (lResult.isSuccess)
                    return Ok(lResult); // Status Code: 200

                return BadRequest(lResult);
            }

            return BadRequest("Some properties are not valid"); // Status Code: 400
        }
    }
}