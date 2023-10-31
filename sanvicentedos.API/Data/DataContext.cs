using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using sanvicentedos.Shared.Entities;

namespace sanvicentedos.API.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<State> States { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
            builder.Entity<City>().HasIndex("Name", "StateId").IsUnique();
            builder.Entity<State>().HasIndex("Name", "CountryId").IsUnique();
        }
    }
}
