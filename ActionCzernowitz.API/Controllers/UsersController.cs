using ActionCzernowitz.BLL.DTOs.Users;
using ActionCzernowitz.BLL.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace ActionCzernowitz.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Receives a Guid type
        /// </summary>
        /// <param name="id"></param>
        /// <returns>User model</returns>
        [HttpGet]
        public async Task<IActionResult> Get(Guid id)
        {
            var user = await _userService.GetAsync(id);

            return user == null ? NotFound() : Ok(user);
        }

        /// <summary>
        /// Action without parameters
        /// </summary>
        /// <returns>List of users</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _userService.GetAllAsync();

            return Ok(users);
        }

        /// <summary>
        /// Has one parameter of UserDto type
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Put(UserDto user)
        {
            user = await _userService.UpdateAsync(user);

            return Ok(user);
        }

        /// <summary>
        /// Guid parameter type
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _userService.DeactivateAsync(id);

            return Ok();
        }
    }
}
