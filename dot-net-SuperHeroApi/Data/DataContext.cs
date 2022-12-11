using Microsoft.EntityFrameworkCore;

namespace dot_net_SuperHeroApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
