using ActionCzernowitz.DAL.Entities;
using Microsoft.AspNetCore.Identity;

namespace ActionCzernowitz.DAL
{
    public static class DataInitializer
    {
        public static async Task Initialize(UserManager<User> userManager)
        {
            if (!userManager.Users.Any())
            {
                var password = "12";
                var user = new User
                {
                    UserName = "admin",
                    FirstName = "Lena",
                    LastName = "Golovach",
                    Email = "admin@gmail.com",
                };

                await userManager.CreateAsync(user, password);
            }
        }
    }
}
