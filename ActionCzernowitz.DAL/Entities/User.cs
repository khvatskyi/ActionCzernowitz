using ActionCzernowitz.DAL.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace ActionCzernowitz.DAL.Entities
{
    public class User : IdentityUser<Guid>, IEntity<Guid>
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public bool IsActive { get; set; }
    }
}
