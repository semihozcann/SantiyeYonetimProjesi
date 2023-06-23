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
    public class ProductionMap : IEntityTypeConfiguration<Production>
    {
        public void Configure(EntityTypeBuilder<Production> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(150);
            builder.Property(p => p.Description).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(250);

            builder.ToTable("Productions");

            builder.HasData(
                new Production
                {
                    Id = 1,
                    Name = "Kolon Demir İmalatı",
                    Description = "Description",
                },
                new Production
                {
                    Id = 2,
                    Name = "Kolon Beton Dökümü İmalatı",
                    Description = "Description",
                },
                new Production
                {
                    Id = 3,
                    Name = "Döşeme Demir İmalatı",
                    Description = "Description",
                },
                new Production
                {
                    Id = 4,
                    Name = "Döşeme Kalıp İmalatı",
                    Description = "Description",
                },
                new Production
                {
                    Id = 5,
                    Name = "Kara Sıva İmalatı",
                    Description = "Description",
                },
                new Production
                {
                    Id = 6,
                    Name = "Duvar İmalatı",
                    Description = "Description",
                },
                new Production
                {
                    Id = 7,
                    Name = "Fayans İmalatı",
                    Description = "Description",
                }
                );
        }
    }
}
