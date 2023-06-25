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
            builder.Property(p => p.ProductionTypeId);

            builder.ToTable("ProjectProductionTypes");
        }
    }
}
