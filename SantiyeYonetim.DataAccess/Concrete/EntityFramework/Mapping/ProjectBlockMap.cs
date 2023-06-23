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
    public class ProjectBlockMap : IEntityTypeConfiguration<ProjectBlock>
    {
        public void Configure(EntityTypeBuilder<ProjectBlock> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(150);

            builder.ToTable("ProjectBlocks");

            builder.HasData(
                new ProjectBlock
                {
                    Id = 1,
                    Name = "A Block",
                },
                new ProjectBlock
                {
                    Id = 2,
                    Name = "B Block",
                },
                new ProjectBlock
                {
                    Id = 3,
                    Name = "C Block",
                },
                new ProjectBlock
                {
                    Id = 4,
                    Name = "D Block",
                },
                new ProjectBlock
                {
                    Id = 5,
                    Name = "E Block",
                },
                new ProjectBlock
                {
                    Id = 6,
                    Name = "F Block",
                }
                );
        }
    }
}
