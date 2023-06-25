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
            builder.Property(p => p.ProjectId);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(150);

            builder.ToTable("ProjectBlocks");

        }
    }
}
