using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Routine.Api.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public string EmployeeNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Company Company { get; set; }
    }

    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("T_Employees");
            builder.Property(v => v.EmployeeNo).IsRequired().HasMaxLength(100);
            builder.Property(v => v.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(v => v.LastName).IsRequired().HasMaxLength(50);

            builder.HasOne(v => v.Company).WithMany(v => v.Employees).HasForeignKey(v => v.CompanyId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
