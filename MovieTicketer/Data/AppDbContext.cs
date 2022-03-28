using Microsoft.EntityFrameworkCore;

namespace MovieTicketer.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }
        

    }
}
