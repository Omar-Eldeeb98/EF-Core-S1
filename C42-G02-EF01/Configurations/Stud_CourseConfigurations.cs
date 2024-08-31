using C42_G02_EF01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_EF01.Configurations
{
    internal class Stud_CourseConfigurations : IEntityTypeConfiguration<Stud_Course>

    {
        public void Configure(EntityTypeBuilder<Stud_Course> builder)
        {
            builder.Property(sc => sc.Grade)
                .HasColumnType("decimal(5, 2)")
                .IsRequired(true);

            builder.HasKey(sc => new { sc.stud_ID, sc.Course_ID });
        }
    }
}