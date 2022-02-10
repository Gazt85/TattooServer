using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfiguration(new UserConfiguration());
        //    modelBuilder.Entity<User>()
        //    .HasIndex(u => u.Email)
        //    .IsUnique();
        //}

        public DbSet<AppointmentData> Appointments { get; set; }
        public DbSet<BlogItem> BlogItems { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
