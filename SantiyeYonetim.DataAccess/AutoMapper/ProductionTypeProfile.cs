using AutoMapper;
using SantiyeYonetim.Entities.Concrete;
using SantiyeYonetim.Entities.DTOs.ProductionTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.DataAccess.AutoMapper
{
    public class ProductionTypeProfile : Profile
    {
        public ProductionTypeProfile()
        {
            CreateMap<ProductionTypeAddDto, ProductionType>();
            CreateMap<ProductionTypeUpdateDto, ProductionType>();
            CreateMap<ProductionType, ProductionTypeUpdateDto>();
        }
    }
}
