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
            builder.Property(p => p.ProjectBlockId);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(150);

            builder.ToTable("ProjectFloors");

        }
    }
}
