using ActionCzernowitz.BLL.DTOs;
using ActionCzernowitz.BLL.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace ActionCzernowitz.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewService _newService;

        public NewsController(INewService newService)
        {
            _newService = newService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _newService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            return Ok(await _newService.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] NewDto newDto)
        {
            return Ok(await _newService.CreateAsync(newDto));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] NewDto newDto)
        {
            if (id != newDto.Id)
            {
                return BadRequest();
            }

            return Ok(await _newService.UpdateAsync(newDto));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _newService.DeleteByIdAsync(id);

            return Ok();
        }
    }
}
