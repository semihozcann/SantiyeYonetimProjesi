using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SantiyeYonetim.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.DataAccess.Concrete.EntityFramework.Mapping
{
    public class CompanyMap : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.CompanyName).IsRequired();
            builder.Property(c => c.CompanyName).HasMaxLength(100);
            builder.Property(c => c.Description).IsRequired();
            builder.Property(c => c.Description).HasMaxLength(250);

            builder.ToTable("Companies");

            builder.HasData(
                new Company
                {
                    Id = 1,
                    CompanyName = "Semih İnşaat",
                    Description = "Description",
                },
                new Company
                {
                    Id = 2,
                    CompanyName = "Halil İnşaat",
                    Description = "Deneme Açıklaması",
                },
                new Company
                {
                    Id = 3,
                    CompanyName = "Hamza İnşaat",
                    Description = "Deneme Açıklaması2",
                }
                );
        }


    }
}
