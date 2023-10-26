using Microsoft.AspNetCore.Identity;

namespace Nekhala.Models
{
    public class Admin : IdentityUser<string>
    {
        public string? AdminName { get; set; }
        public string? AdminRole { get; set; }
        public string? AdminEntity { get; set; }
    }
}
