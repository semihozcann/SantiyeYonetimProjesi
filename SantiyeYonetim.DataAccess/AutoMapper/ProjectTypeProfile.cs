using AutoMapper;
using SantiyeYonetim.Entities.Concrete;
using SantiyeYonetim.Entities.DTOs.ProjectTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.DataAccess.AutoMapper
{
    public class ProjectTypeProfile : Profile
    {
        public ProjectTypeProfile()
        {
            CreateMap<ProjectTypeAddDto, ProjectType>();
            CreateMap<ProjectTypeUpdateDto, ProjectType>();
            CreateMap<ProjectType, ProjectTypeUpdateDto>();
        }
    }
}
