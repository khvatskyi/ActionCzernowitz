using ActionCzernowitz.BLL.DTOs.Users;
using Microsoft.AspNetCore.Identity;

namespace ActionCzernowitz.BLL.Interfaces.IServices
{
    public interface IAuthService
    {
        Task<SignInResult> AuthenticateAsync(LoginDto loginModel);

        Task<IdentityResult> CreateAsync(RegistrationDto registrationModel);

        Task SignOutAsync();
    }
}
