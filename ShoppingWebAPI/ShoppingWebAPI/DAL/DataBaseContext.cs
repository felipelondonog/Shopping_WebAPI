﻿using Microsoft.EntityFrameworkCore;
using ShoppingWebAPI.DAL.Entities;

namespace ShoppingWebAPI.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        private DbSet<Country> Countries { get; set; } //Countries es el nombre de la tabla

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
        }
    }
}
