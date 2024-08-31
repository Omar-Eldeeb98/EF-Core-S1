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

            //-----------------------> Settup Relationships Between Tables "Entities" <----------------------------

            // one-to-many relationship between Student and Department
            modelBuilder.Entity<Department>()
                .HasMany(d => d.Students)
                .WithOne(s => s.Department)
                .HasForeignKey(s => s.Dep_Id);

            //  many-to-many relationship between Student and Course
            modelBuilder.Entity<Stud_Course>()
                .HasKey(sc => new { sc.stud_ID, sc.Course_ID });

            modelBuilder.Entity<Stud_Course>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudentsCourse)
                .HasForeignKey(sc => sc.stud_ID);

            modelBuilder.Entity<Stud_Course>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.CoursesStudent)
                .HasForeignKey(sc => sc.Course_ID);

            // one-to-many relationship between Course and Topic
            modelBuilder.Entity<Topic>()
                .HasMany(t => t.Courses)
                .WithOne(c => c.Topic)
                .HasForeignKey(c => c.Top_ID);

            // many-to-many relationship between Course - Instructor
            modelBuilder.Entity<Course_Inst>()
                .HasKey(ci => new { ci.Course_ID, ci.inst_ID });

            modelBuilder.Entity<Course>()
                .HasMany(c => c.Course_Insts)
                .WithOne(ci => ci.Course)
                .HasForeignKey(ci => ci.Course_ID);

            modelBuilder.Entity<Instructor>()
                .HasMany(i => i.Course_Insts)
                .WithOne(ci => ci.Instructor)
                .HasForeignKey(ci => ci.inst_ID);

            // one-to-many relationship between Instructor - Department
            modelBuilder.Entity<Department>()
                .HasMany(d => d.Instructors)
                .WithOne(i => i.Department)
                .HasForeignKey(i => i.Dept_ID);

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