using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreCodeFirstApproach.Data
{
    public class ProductDBContext : DbContext
    {

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-6D83937;Database=FullStack_ProductDB;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<Models.Product> Products { get; set; }

        //Fluent API configuration can be done here if needed

        override protected void OnModelCreating(ModelBuilder modelBuilder)

        {

            // Example of Fluent API configuration

            modelBuilder.Entity<Models.Product>()

                .Property(p => p.Name)

                .IsRequired()

                .HasMaxLength(100);

            modelBuilder.Entity<Models.Product>()

                .Property(p => p.Price)

                .IsRequired();

            modelBuilder.Entity<Models.Product>()

                .Property(p => p.Description)

                .HasDefaultValue(string.Empty);

            //to seed data

            modelBuilder.Entity<Models.Product>().HasData(

                new Models.Product { Id = 1, Name = "Product 1", Price = 10.0f, Description = "Description for Product 1" },

                new Models.Product { Id = 2, Name = "Product 2", Price = 20.0f, Description = "Description for Product 2" },

                new Models.Product { Id = 3, Name = "Product 3", Price = 30.0f, Description = "Description for Product 3" }

            );

        }
    }
}
