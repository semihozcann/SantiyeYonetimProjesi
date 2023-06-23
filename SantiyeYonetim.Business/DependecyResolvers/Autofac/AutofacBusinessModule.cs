using Autofac;
using Microsoft.EntityFrameworkCore;
using SantiyeYonetim.DataAccess.Concrete.EntityFramework;
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



        }
    }
}
