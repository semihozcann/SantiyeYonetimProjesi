using SantiyeYonetim.Core.Utilities.Result.Abstract;
using SantiyeYonetim.Entities.Concrete;
using SantiyeYonetim.Entities.DTOs.Producions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Business.Abstract
{
    public interface IProductionService
    {
        Task<IDataResult<Production>> GetByIdAsync(int productionId);
        Task<IDataResult<List<Production>>> GetAllAsync();
        Task<IResult> AddAsync(ProductionAddDto productionAddDto);
        Task<IResult> UpdateAsync(ProductionUpdateDto productionUpdateDto);
        Task<IResult> DeleteAsync(int productionId);

        List<Production> GetCategories();
    }
}
