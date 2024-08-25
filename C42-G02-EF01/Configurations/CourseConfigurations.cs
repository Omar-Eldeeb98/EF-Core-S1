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
    internal class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.ID);
            builder.Property(c => c.ID)
                .UseIdentityColumn(1, 1);

            builder.Property(c => c.Name)
                            .HasMaxLength(50)
                            .HasDefaultValue("Math");

            builder.Property(c => c.Duration)
                .HasColumnType("nvarchar(50)");

            builder.Property(c => c.Description)
                .HasMaxLength(500);
        }
    }
}