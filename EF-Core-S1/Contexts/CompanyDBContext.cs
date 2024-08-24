using EF_Core_S1.Configurations;
using EF_Core_S1.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_S1.Contexts
{
    internal class CompanyDBContext: DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfigurations());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = CompanyDB; Trusted_Connection=True; TrustServerCertificate=true");  // open connect between sql server and project in visual studio
        }

        public DbSet<Employee> Employees { get; set; }
        public  DbSet<Department> Departments { get; set; }


   
    }
}
