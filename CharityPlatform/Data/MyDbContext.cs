using CharityPlatform.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CharityPlatform.Data
{
    public class MyDbContext : IdentityDbContext<User>
    {
        public new DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<DonatedItem> DonatedItems { get; set; }
        public DbSet<PostImage> PostImages { get; set; }
        public DbSet<Target> Targets { get; set; }

        public MyDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
