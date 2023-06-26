using AutoMapper;
using SantiyeYonetim.Entities.Concrete;
using SantiyeYonetim.Entities.DTOs.ProjectProductionImages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.DataAccess.AutoMapper
{
    public class ProjectProductionImageProfile : Profile
    {
        public ProjectProductionImageProfile()
        {
            CreateMap<ProjectProductionImageAddDto, ProjectProductionImage>();
            CreateMap<ProjectProductionImageUpdateDto, ProjectProductionImage>();
            CreateMap<ProjectProductionImage, ProjectProductionImageUpdateDto>();
        }
    }
}
