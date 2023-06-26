using AutoMapper;
using SantiyeYonetim.Entities.Concrete;
using SantiyeYonetim.Entities.DTOs.ProjectFloors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.DataAccess.AutoMapper
{
    public class ProjectFloorProfile : Profile
    {
        public ProjectFloorProfile()
        {
            CreateMap<ProjectFloorAddDto, ProjectFloor>();
            CreateMap<ProjectFloorUpdateDto, ProjectFloor>();
            CreateMap<ProjectFloor, ProjectFloorUpdateDto>();
        }
    }
}
