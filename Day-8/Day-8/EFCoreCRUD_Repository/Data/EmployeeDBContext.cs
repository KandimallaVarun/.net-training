using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreCRUD_Repository.Data
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<EFCoreCRUD_Repository.Models.Employee> Employees { get; set; }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-6D83937;Database=FullStack_EmployeeDB;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
