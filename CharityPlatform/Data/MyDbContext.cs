using CharityPlatform.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CharityPlatform.Data
{
    public class MyDbContext : IdentityDbContext<User>
    {
        public new DbSet<User> Users { get; set; }

        public MyDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
