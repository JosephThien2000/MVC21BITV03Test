using Microsoft.AspNetCore.Identity;

namespace Nhom04MidTest.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}