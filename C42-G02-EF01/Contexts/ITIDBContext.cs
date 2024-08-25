using C42_G02_EF01.Configurations;
using C42_G02_EF01.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_EF01.Contexts
{
    internal class ITIDBContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Course>(new CourseConfigurations());
            modelBuilder.ApplyConfiguration<Stud_Course>(new Stud_CourseConfigurations());
            modelBuilder.ApplyConfiguration<Course_Inst>(new Course_InstConfigurations());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = ITIDB; Trusted_Connection=True; TrustServerCertificate=true");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }
    }
}