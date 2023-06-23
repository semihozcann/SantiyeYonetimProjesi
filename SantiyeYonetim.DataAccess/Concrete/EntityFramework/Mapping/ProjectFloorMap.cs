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
    public class ProjectFloorMap : IEntityTypeConfiguration<ProjectFloor>
    {
        public void Configure(EntityTypeBuilder<ProjectFloor> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(150);

            builder.ToTable("ProjectFloors");

            builder.HasData(
                new ProjectFloor
                {
                    Id = 1,
                    Name = "1. Kat",
                },
                new ProjectFloor
                {
                    Id = 2,
                    Name = "2. Kat",
                },
                new ProjectFloor
                {
                    Id = 3,
                    Name = "3. Kat",
                },
                new ProjectFloor
                {
                    Id = 4,
                    Name = "4. Kat",
                },
                new ProjectFloor
                {
                    Id = 5,
                    Name = "5. Kat",
                },
                new ProjectFloor
                {
                    Id = 6,
                    Name = "6. Kat",
                },
                new ProjectFloor
                {
                    Id = 7,
                    Name = "7. Kat",
                }
                );
        }
    }
}
