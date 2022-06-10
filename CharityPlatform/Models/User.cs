using Microsoft.AspNetCore.Identity;

namespace CharityPlatform.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public string Address { get; set; }
    }
}
