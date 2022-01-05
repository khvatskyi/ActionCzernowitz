using ActionCzernowitz.BLL.DTOs.Users;
using ActionCzernowitz.BLL.Interfaces.IServices;
using ActionCzernowitz.DAL.EF;
using ActionCzernowitz.DAL.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ActionCzernowitz.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;

        public UserService(UserManager<User> userManager,
            ApplicationContext context,
            IMapper mapper)
        {
            _userManager = userManager;
            _context = context;
            _mapper = mapper;
        }

        public async Task<UserDto> GetAsync(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());

            return _mapper.Map<UserDto>(user);
        }

        public async Task<UserDto> GetByNameAsync(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);

            return _mapper.Map<UserDto>(user);
        }

        public async Task<IEnumerable<UserDto>> GetAllAsync()
        {
            var users = await _userManager.Users.ToListAsync();

            return _mapper.Map<IEnumerable<UserDto>>(users);
        }

        public async Task<UserDto> UpdateAsync(UserDto userDto)
        {
            var user = await _userManager.FindByIdAsync(userDto.Id.ToString());

            _mapper.Map(userDto, user);
            await _context.SaveChangesAsync();

            return _mapper.Map<UserDto>(user);
        }

        public async Task<UserDto> DeactivateAsync(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());

            user.IsActive = false;
            await _context.SaveChangesAsync();

            return _mapper.Map<UserDto>(user);
        }
    }
}
