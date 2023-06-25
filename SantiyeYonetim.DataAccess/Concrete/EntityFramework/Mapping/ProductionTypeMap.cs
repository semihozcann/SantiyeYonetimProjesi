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
    public class ProductionTypeMap : IEntityTypeConfiguration<ProductionType>
    {
        public void Configure(EntityTypeBuilder<ProductionType> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(150);
            builder.Property(p => p.SmallName).IsRequired();

            builder.ToTable("ProductionTypes");

            builder.HasData(
                new ProductionType
                {
                    Id = 1,
                    Name = "HAFRİYAT",
                    SmallName = 'H'
                },
                new ProductionType
                {
                    Id = 2,
                    Name = "KABA İŞLER",
                    SmallName = 'K'
                },
                new ProductionType
                {
                    Id = 3,
                    Name = "İNCE İŞLER",
                    SmallName = 'İ'
                },
                new ProductionType
                {
                    Id = 4,
                    Name = "ELEKTRİK İŞLERİ",
                    SmallName = 'E'
                },
                new ProductionType
                {
                    Id = 5,
                    Name = "MAKİNE İŞLERİ",
                    SmallName = 'M'
                }
                );
        }
    }
}
