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
    public class ProjectProductionTypeMap : IEntityTypeConfiguration<ProjectProductionType>
    {
        public void Configure(EntityTypeBuilder<ProjectProductionType> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(150);

            builder.ToTable("ProjectProductionTypes");

            builder.HasData(
                new ProjectProductionType
                {
                    Id = 1,
                    Name = "Kaba İşler"
                },
                new ProjectProductionType
                {
                    Id = 2,
                    Name = "İnce İşler"
                },
                new ProjectProductionType
                {
                    Id = 3,
                    Name = "Temel"
                },
                new ProjectProductionType
                {
                    Id = 4,
                    Name = "Fore Kazık"
                },
                new ProjectProductionType
                {
                    Id = 5,
                    Name = "Dsm"
                }
                );
        }
    }
}
