using ActionCzernowitz.BLL.DTOs.Users;

namespace ActionCzernowitz.BLL.Interfaces.IServices
{
    public interface IUserService
    {
        Task<UserDto> GetAsync(Guid id);

        Task<UserDto> GetByNameAsync(string userName);

        Task<IEnumerable<UserDto>> GetAllAsync();

        Task<UserDto> UpdateAsync(UserDto userDto);

        Task<UserDto> DeactivateAsync(Guid id);
    }
}
