using ActionCzernowitz.API.Interfaces;
using ActionCzernowitz.BLL.DTOs.Users;
using ActionCzernowitz.BLL.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace ActionCzernowitz.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IUserService _userService;
        private readonly IJwtTokenService _tokenService;

        public AuthenticationController(IAuthService authService,
            IUserService userService,
            IJwtTokenService tokenService)
        {
            _authService = authService;
            _userService = userService;
            _tokenService = tokenService;
        }

        [HttpPost]
        public async Task<IActionResult> Authorize([FromBody] LoginDto loginModel)
        {
            var result = await _authService.AuthenticateAsync(loginModel);

            if (result.Succeeded)
            {
                var user = _userService.GetByNameAsync(loginModel.UserName);

                return Ok(_tokenService.GenerateJwtAccessToken(user.Id.ToString()));
            }

            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] RegistrationDto registrationModel)
        {
            var result = await _authService.CreateAsync(registrationModel);

            return result.Succeeded ? Ok(result) : BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _authService.SignOutAsync();

            return Ok();
        }
    }
}
