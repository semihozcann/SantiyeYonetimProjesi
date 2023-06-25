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
    public class ProjectProductionMap : IEntityTypeConfiguration<ProjectProduction>
    {
        public void Configure(EntityTypeBuilder<ProjectProduction> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.ProductionId);
            builder.Property(p => p.DrawingFilePath);
            builder.Property(p => p.AdminNote).HasMaxLength(250);
            builder.Property(p => p.UserNote).HasMaxLength(250);
            builder.Property(p => p.CompletionStatus);
            builder.Property(p => p.UpdatedPeople);
            builder.Property(p => p.ProductionStartDate);
            builder.Property(p => p.ProductionEndDate);
            builder.Property(p => p.TotalProductionDays);

            builder.ToTable("ProjectProductions");
        }
    }
}
