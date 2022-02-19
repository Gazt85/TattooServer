using Entities.Configuration;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
          : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique();

            modelBuilder.ApplyConfiguration(new AppointmentCofiguration());
            modelBuilder.ApplyConfiguration(new AppointmentStatusDataConfiguration());
            modelBuilder.ApplyConfiguration(new BlogItemConfiguration());
            modelBuilder.ApplyConfiguration(new BlogPostConfiguration());
            modelBuilder.ApplyConfiguration(new PreviousTattooDataConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new VideoConfiguration());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<AppointmentData> Appointments { get; set; }
        public DbSet<AppointmentStatusData> AppointmentStatus { get; set; }
        public DbSet<BlogItem> BlogItems { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
