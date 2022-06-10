using Microsoft.EntityFrameworkCore;

namespace CharityPlatform.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
