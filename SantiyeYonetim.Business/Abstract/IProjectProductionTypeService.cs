using SantiyeYonetim.Core.Utilities.Result.Abstract;
using SantiyeYonetim.Entities.Concrete;
using SantiyeYonetim.Entities.DTOs.ProjectProductions;
using SantiyeYonetim.Entities.DTOs.ProjectProductionTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Business.Abstract
{
    public interface IProjectProductionTypeService
    {
        Task<IDataResult<ProjectProductionType>> GetByIdAsync(int propjectProductionTypeId);
        Task<IDataResult<List<ProjectProductionType>>> GetAllAsync();
        Task<IResult> AddAsync(ProjectProductionTypeAddDto projectProductionTypeAddDto);
        Task<IResult> UpdateAsync(ProjectProductionTypeUpdateDto projectProductionTypeUpdateDto);
        Task<IResult> DeleteAsync(int propjectProductionTypeId);

        List<ProjectProductionType> GetAllProjectProductionType();

        int LastId();
    }
}
