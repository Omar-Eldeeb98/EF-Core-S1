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
    internal class Course_InstConfigurations : IEntityTypeConfiguration<Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> builder)
        {
            builder.HasKey(ci => new { ci.inst_ID, ci.Course_ID });

            builder.Property(ci => ci.evaluate)
                .HasMaxLength(30)
                .IsRequired(false);
        }
    }
}