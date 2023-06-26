using Microsoft.Extensions.DependencyInjection;
using SantiyeYonetim.Core.Utilities.IoC;
using SantiyeYonetim.DataAccess.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Business.DependecyResolvers
{
    public class AutoMapperModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddAutoMapper(
                typeof(CompanyProfile),
                typeof(ProductionProfile),
                typeof(ProductionTypeProfile),
                typeof(ProjectBlockProfile),
                typeof(ProjectFloorProfile),
                typeof(ProjectProductionImageProfile),
                typeof(ProjectProductionProfile),
                typeof(ProjectProductionTypeProfile),
                typeof(ProjectProfile),
                typeof(ProjectTypeProfile)
                );
        }
    }
}
