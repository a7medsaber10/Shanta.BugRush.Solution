

using Microsoft.AspNetCore.Identity;

namespace Shanta.Core.Entities.Identity
{
    public class AppUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? ProfilePictureUrl { get; set; }
    }
}

