using Microsoft.AspNetCore.Identity;

namespace CharityPlatform.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual Donation Donation { get; set; }
    }
}
