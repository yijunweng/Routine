using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Routine.Api.Entities
{
    public class Company
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Introduction { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }

    public class CompanyConfig : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("T_Companies");
            builder.Property(v => v.Name).IsRequired().HasMaxLength(100);
            builder.Property(v => v.Introduction).IsRequired().HasMaxLength(500);

            builder.HasData(
                new Company
                {
                    Id = Guid.Parse("d68c6076-0134-d879-f7af-71b5de57db98"),
                    Name = "Microsoft",
                    Introduction = "Great Company"
                },
                new Company
                {
                    Id = Guid.Parse("a152ab69-1134-d879-f7b9-ea5f99f454c9"),
                    Name = "Google",
                    Introduction = "Dont be evil"
                },
                new Company
                {
                    Id = Guid.Parse("faf161f4-a134-d879-f7d6-c654cbd7844a"),
                    Name = "Alipapa",
                    Introduction = "Fubao Company"
                });
        }
    }
}
