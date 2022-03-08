using Microsoft.EntityFrameworkCore;

namespace SuperHeroApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        // DbSet, seta o nome do banco de dados
        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
