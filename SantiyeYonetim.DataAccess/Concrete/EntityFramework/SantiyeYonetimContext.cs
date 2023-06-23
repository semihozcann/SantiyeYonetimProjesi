using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SantiyeYonetim.DataAccess.Concrete.EntityFramework.Mapping;
using SantiyeYonetim.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.DataAccess.Concrete.EntityFramework
{
    public class SantiyeYonetimContext : IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        public SantiyeYonetimContext()
        {
            
        }

        public SantiyeYonetimContext(DbContextOptions<SantiyeYonetimContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=DESKTOP-5R6CJJ3\SQLEXPRESS;Database=SantiyeYonetimDb;Trusted_Connection=true");

            }
            base.OnConfiguring(optionsBuilder);



        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Production> Productions { get; set; }
        public DbSet<ProjectBlock> ProjectBlocks { get; set; }
        public DbSet<ProjectFloor> ProjectFloors { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectProductionImage> ProjectProductionImages { get; set; }
        public DbSet<ProjectProduction> ProjectProductions { get; set; }
        public DbSet<ProjectProductionType> ProjectProductionTypes { get; set; }
        public DbSet<ProjectType> ProjectTypes { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration(new RoleMap());
            builder.ApplyConfiguration(new UserMap());
            builder.ApplyConfiguration(new UserTokenMap());
            builder.ApplyConfiguration(new UserRoleMap());
            builder.ApplyConfiguration(new UserLoginMap());
            builder.ApplyConfiguration(new RoleClaimMap());
            builder.ApplyConfiguration(new UserClaimMap());


            builder.ApplyConfiguration(new CompanyMap());
            builder.ApplyConfiguration(new ProductionMap());
            builder.ApplyConfiguration(new ProjectBlockMap());
            builder.ApplyConfiguration(new ProjectFloorMap());
            builder.ApplyConfiguration(new ProjectMap());
            builder.ApplyConfiguration(new ProjectProductionImageMap());
            builder.ApplyConfiguration(new ProjectProductionMap());
            builder.ApplyConfiguration(new ProjectProductionTypeMap());
            builder.ApplyConfiguration(new ProjectTypeMap());


        }
    }
}
