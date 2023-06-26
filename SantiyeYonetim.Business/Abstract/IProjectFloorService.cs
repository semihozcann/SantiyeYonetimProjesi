using SantiyeYonetim.Core.Utilities.Result.Abstract;
using SantiyeYonetim.Entities.Concrete;
using SantiyeYonetim.Entities.DTOs.ProjectFloors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Business.Abstract
{
    public interface IProjectFloorService
    {
        Task<IDataResult<ProjectFloor>> GetByIdAsync(int projectFloorId);
        Task<IDataResult<List<ProjectFloor>>> GetAllAsync();
        Task<IResult> AddAsync(ProjectFloorAddDto projectFloorAddDto);
        Task<IResult> UpdateAsync(ProjectFloorUpdateDto projectFloorUpdateDto);
        Task<IResult> DeleteAsync(int projectFloorId);

        List<ProjectFloor> GetAllProjectFloor();
    }
}
