using EF_Core_S1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_S1.Configurations
{
    internal class StudentCourseConfigurations : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.HasKey(sc => new { sc.StudentId, sc.CourseId }); // composite pk

            builder.HasOne(sc => sc.Student)
            .WithMany(s => s.StudentCourses)
            .IsRequired(true)
            .HasForeignKey(sc => sc.StudentId);

            builder.HasOne(sc => sc.Course)
            .WithMany(c => c.CourseStudents)
            .IsRequired(true)
            .HasForeignKey(sc => sc.CourseId);
        }
    }
}