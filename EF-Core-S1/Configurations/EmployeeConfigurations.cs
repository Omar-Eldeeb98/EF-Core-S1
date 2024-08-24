using EF_Core_S1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_S1.Configurations
{
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(Emp => Emp.EmpID); // choose the pk of  Entity

           builder.Property(Emp => Emp.EmpID)
                .UseIdentityColumn(1, 1);  // pk constraint

            builder.Property(Emp => Emp.Name)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .HasDefaultValue("Omar");


          builder.Property(Emp => Emp.Salary)
                .HasColumnType("money");


           builder.Property(Emp => Emp.Address)
                .HasMaxLength(50)
                .HasDefaultValue("Alexandria");

        }
    }
}
