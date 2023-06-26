using AutoMapper;
using SantiyeYonetim.Entities.Concrete;
using SantiyeYonetim.Entities.DTOs.ProjectBlocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.DataAccess.AutoMapper
{
    public class ProjectBlockProfile : Profile
    {
        public ProjectBlockProfile()
        {
            CreateMap<ProjectBlockAddDto, ProjectBlock>();
            CreateMap<ProjectBlockUpdateDto, ProjectBlock>();
            CreateMap<ProjectBlock, ProjectBlockUpdateDto>();
        }
    }
}
