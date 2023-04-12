using Microsoft.EntityFrameworkCore;
using ShoppingWebAPI.DAL.Entities;

namespace ShoppingWebAPI.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; } //Countries es el nombre de la tabla
        public DbSet<Category> Categories { get; set; } //Countries es el nombre de la tabla
        public DbSet<State> States { get; set; } //Countries es el nombre de la tabla
        public DbSet<City> Cities { get; set; } //Countries es el nombre de la tabla

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Category>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<State>().HasIndex("Name", "CountryId").IsUnique();
            modelBuilder.Entity<City>().HasIndex("Name", "StateId").IsUnique();
        }
    }
}
