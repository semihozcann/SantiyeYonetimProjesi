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
    public class ProjectTypeMap : IEntityTypeConfiguration<ProjectType>
    {
        public void Configure(EntityTypeBuilder<ProjectType> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(150);
            builder.Property(p => p.Description).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(250);

            builder.ToTable("ProjectTypes");

            builder.HasData(
                new ProjectType
                {
                    Id = 1,
                    Name = "Konut Projesi",
                    Description = "Description"
                },
                new ProjectType
                {
                    Id = 2,
                    Name = "Hidroelektrik Santral Projesi",
                    Description = "Description"
                },
                new ProjectType
                {
                    Id = 3,
                    Name = "Hastane Projesi",
                    Description = "Description"
                }
                );
        }
    }
}
