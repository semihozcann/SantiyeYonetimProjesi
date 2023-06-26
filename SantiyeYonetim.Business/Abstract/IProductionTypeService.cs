using SantiyeYonetim.Core.Utilities.Result.Abstract;
using SantiyeYonetim.Entities.Concrete;
using SantiyeYonetim.Entities.DTOs.ProductionTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Business.Abstract
{
    public interface IProductionTypeService
    {
        Task<IDataResult<ProductionType>> GetByIdAsync(int productionTypeId);
        Task<IDataResult<List<ProductionType>>> GetAllAsync();
        Task<IResult> AddAsync(ProductionTypeAddDto productionTypeAddDto);
        Task<IResult> UpdateAsync(ProductionTypeUpdateDto productionTypeUpdateDto);
        Task<IResult> DeleteAsync(int productionTypeId);

        List<ProductionType> GetAllProductionType();
    }
}
