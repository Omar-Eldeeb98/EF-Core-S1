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
    internal class CompanyDBContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfigurations()); // class configurations way
            modelBuilder.ApplyConfiguration<StudentCourse>(new StudentCourseConfigurations()); // class configurations way

            #region ----> 1 - One to One by fluentapi  <-----------

            // modelBuilder.Entity<Employee>()
            //.HasOne(e => e.Department)
            //.WithOne(d => d.Manager)
            //.HasForeignKey<Department>(d => d.MEmpId);

            #endregion ----> 1 - One to One by fluentapi  <-----------

            #region ----> 2 - One to many by fluentapi  <-----------

            //modelBuilder.Entity<Department>()
            //    .HasMany(d=>d.Employees)
            //    .WithOne(e=>e.Workfor)
            //    .HasForeignKey(e=>e.WorkforId);

            #endregion ----> 2 - One to many by fluentapi  <-----------

            #region ----> 3 - many to many by fluentapi  <-----------

            //modelBuilder.Entity<StudentCourse>() // composite pk
            //    .HasKey(sc => new { sc.StudentId, sc.CourseId });

            //modelBuilder.Entity<Student>()
            //    .HasMany(s => s.StudentCourses)
            //    .WithOne(sc => sc.Student)
            //    .IsRequired(true)
            //    .HasForeignKey(sc => sc.StudentId);

            //modelBuilder.Entity<Course>()
            //    .HasMany(c => c.CourseStudents)
            //    .WithOne(sc => sc.Course)
            //    .IsRequired(true)
            //    .HasForeignKey(sc => sc.CourseId);

            #endregion ----> 3 - many to many by fluentapi  <-----------

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = CompanyDB; Trusted_Connection=True; TrustServerCertificate=true");  // open connect between sql server and project in visual studio
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}