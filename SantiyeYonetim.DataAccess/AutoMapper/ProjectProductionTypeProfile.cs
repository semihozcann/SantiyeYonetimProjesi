using AutoMapper;
using SantiyeYonetim.Entities.Concrete;
using SantiyeYonetim.Entities.DTOs.ProjectProductionTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.DataAccess.AutoMapper
{
    public class ProjectProductionTypeProfile : Profile
    {
        public ProjectProductionTypeProfile()
        {
            CreateMap<ProjectProductionTypeAddDto, ProjectProductionType>();
            CreateMap<ProjectProductionTypeUpdateDto, ProjectProductionType>();
            CreateMap<ProjectProductionType, ProjectProductionTypeUpdateDto>();
        }
    }
}
