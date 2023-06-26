using SantiyeYonetim.Core.Utilities.Result.Abstract;
using SantiyeYonetim.Entities.Concrete;
using SantiyeYonetim.Entities.DTOs.ProjectProductions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Business.Abstract
{
    public interface IProjectProductionService
    {
        Task<IDataResult<ProjectProduction>> GetByIdAsync(int projectProductionId);
        Task<IDataResult<List<ProjectProduction>>> GetAllAsync();
        Task<IResult> AddAsync(ProjectProductionAddDto projectProductionAddDto);
        Task<IResult> UpdateAsync(ProjectProductionUpdateDto projectProductionUpdateDto);
        Task<IResult> DeleteAsync(int projectProductionId);

        List<ProjectProduction> GetAllProjectProduction();
    }
}
