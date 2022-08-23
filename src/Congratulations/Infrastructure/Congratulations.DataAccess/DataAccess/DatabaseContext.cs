﻿using Sev1.Congratulations.Domain;
using Sev1.Congratulations.DataAccess.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;


namespace Sev1.Congratulations.DataAccess
{
    /// <summary>
    /// Базовый контекст приложения.
    /// </summary>
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Congratulation> Congratulations { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<UserFile> UserFiles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CongratulationConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new TagConfiguration());
            modelBuilder.ApplyConfiguration(new RegionConfiguration());
            modelBuilder.ApplyConfiguration(new UserFileConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}