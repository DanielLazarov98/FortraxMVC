using System;
using System.Collections.Generic;
using System.Text;
using FortraxMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FortraxMVC.ViewModels;

namespace FortraxMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Lottery> Lotteries { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                 .HasMany(u => u.Comments)
                 .WithOne(c => c.Author)
                 .HasForeignKey(c => c.AuthorId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Orders)
                .WithOne(c => c.Issuer)
                .HasForeignKey(c => c.IssuerId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Tickets)
                .WithOne(c => c.User)
                .HasForeignKey(c => c.UserId);

            modelBuilder.Entity<Product>()
              .HasMany(u => u.Orders)
              .WithOne(c => c.Product)
              .HasForeignKey(c => c.ProductId);

            modelBuilder.Entity<Product>()
              .HasMany(u => u.Comments)
              .WithOne(c => c.Product)
              .HasForeignKey(c => c.ProductId);

            modelBuilder.Entity<Lottery>()
              .HasMany(u => u.Tickets)
              .WithOne(c => c.Lottery)
              .HasForeignKey(c => c.LotteryId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<FortraxMVC.ViewModels.ProductDetailsViewModel> ProductDetailsViewModel { get; set; }
    }
}
