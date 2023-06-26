using Autofac;
using Microsoft.EntityFrameworkCore;
using SantiyeYonetim.Business.Abstract;
using SantiyeYonetim.Business.Concrete;
using SantiyeYonetim.DataAccess.Abstract;
using SantiyeYonetim.DataAccess.Concrete.EntityFramework;
using SantiyeYonetim.DataAccess.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Business.DependecyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<SantiyeYonetimContext>().As<DbContext>().SingleInstance();

            builder.RegisterType<EfCompanyDal>().As<ICompanyDal>();
            builder.RegisterType<CompanyManager>().As<ICompanyService>();

            builder.RegisterType<EfProductionDal>().As<IProductionDal>();
            builder.RegisterType<ProductionManager>().As<IProductionService>();

            builder.RegisterType<EfProductionTypeDal>().As<IProductionTypeDal>();
            builder.RegisterType<ProductionTypeManager>().As<IProductionTypeService>();

            builder.RegisterType<EfProjectBlockDal>().As<IProjectBlockDal>();
            builder.RegisterType<ProjectBlockManager>().As<IProjectBlockService>();

            builder.RegisterType<EfProjectFloorDal>().As<IProjectFloorDal>();
            builder.RegisterType<ProjectFloorManager>().As<IProjectFloorService>();

            builder.RegisterType<EfProjectProductionImageDal>().As<IProjectProductionImageDal>();
            builder.RegisterType<ProjectProductionImageManager>().As<IProjectProductionImageService>();

            builder.RegisterType<EfProjectProductionDal>().As<IProjectProductionDal>();
            builder.RegisterType<ProjectProductionManager>().As<IProjectProductionService>();

            builder.RegisterType<EfProjectProductionTypeDal>().As<IProjectProductionTypeDal>();
            builder.RegisterType<ProjectProductionTypeManager>().As<IProjectProductionTypeService>();

            builder.RegisterType<EfProjectDal>().As<IProjectDal>();
            builder.RegisterType<ProjectManager>().As<IProjectService>();

            builder.RegisterType<EfProjectTypeDal>().As<IProjectTypeDal>();
            builder.RegisterType<ProjectTypeManager>().As<IProjectTypeService>();


        }
    }
}
