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
    public class ProjectProductionImageMap : IEntityTypeConfiguration<ProjectProductionImage>
    {
        public void Configure(EntityTypeBuilder<ProjectProductionImage> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.ProjectProductionId).IsRequired();
            builder.Property(p => p.ImageUrl).IsRequired();

            builder.ToTable("ProjectProductionImages");
        }
    }
}
