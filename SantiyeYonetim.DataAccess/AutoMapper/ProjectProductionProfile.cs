using AutoMapper;
using SantiyeYonetim.Entities.Concrete;
using SantiyeYonetim.Entities.DTOs.ProjectProductions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.DataAccess.AutoMapper
{
    public class ProjectProductionProfile : Profile
    {
        public ProjectProductionProfile()
        {
            CreateMap<ProjectProductionAddDto, ProjectProduction>();
            CreateMap<ProjectProductionUpdateDto, ProjectProduction>();
            CreateMap<ProjectProduction, ProjectProductionUpdateDto>();
        }
    }
}
