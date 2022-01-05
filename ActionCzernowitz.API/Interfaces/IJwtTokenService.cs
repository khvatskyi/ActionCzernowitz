using ActionCzernowitz.BLL.DTOs.Users;

namespace ActionCzernowitz.API.Interfaces
{
    public interface IJwtTokenService
    {
        string GenerateJwtAccessToken(string userId);

        string GenerateJwtIdToken(UserDto user);
    }
}
