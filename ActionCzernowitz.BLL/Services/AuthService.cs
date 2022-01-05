using ActionCzernowitz.BLL.DTOs.Users;
using ActionCzernowitz.BLL.Interfaces.IServices;
using ActionCzernowitz.DAL.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace ActionCzernowitz.BLL.Services
{
    public class AuthService : IAuthService
    {
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AuthService(IMapper mapper,
            UserManager<User> userManager,
            SignInManager<User> signInManager)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<SignInResult> AuthenticateAsync(LoginDto loginModel)
        {
            var user = await _userManager.FindByNameAsync(loginModel.UserName);

            return await _signInManager.PasswordSignInAsync(user, loginModel.Password, loginModel.RememberMe, false);
        }

        public async Task<IdentityResult> CreateAsync(RegistrationDto registrationModel)
        {
            var user = _mapper.Map<User>(registrationModel);

            var result = await _userManager.CreateAsync(user, registrationModel.ConfirmPassword);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, false);
            }

            return result;
        }

        public async Task SignOutAsync()
        {
            await _signInManager.SignOutAsync();
        }
    }
}
