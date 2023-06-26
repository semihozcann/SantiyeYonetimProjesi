using AutoMapper;
using SantiyeYonetim.Entities.Concrete;
using SantiyeYonetim.Entities.DTOs.Producions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.DataAccess.AutoMapper
{
    public class ProductionProfile : Profile
    {
        public ProductionProfile()
        {
            CreateMap<ProductionAddDto, Production>();
            CreateMap<ProductionUpdateDto, Production>();
            CreateMap<Production, ProductionUpdateDto>();
        }
    }
}
