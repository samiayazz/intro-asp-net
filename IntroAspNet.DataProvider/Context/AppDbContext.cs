﻿using IntroAspNet.Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace IntroAspNet.DataProvider.Context
{
    public class AppDbContext : DbContext
    {
        protected AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Image> Images { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
