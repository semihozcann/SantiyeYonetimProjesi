using SantiyeYonetim.Core.Utilities.Result.Abstract;
using SantiyeYonetim.Entities.Concrete;
using SantiyeYonetim.Entities.DTOs.ProjectTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Business.Abstract
{
    public interface IProjectTypeService
    {
        Task<IDataResult<ProjectType>> GetByIdAsync(int projectTypeId);
        Task<IDataResult<List<ProjectType>>> GetAllAsync();
        Task<IResult> AddAsync(ProjectTypeAddDto projectTypeAddDto);
        Task<IResult> UpdateAsync(ProjectTypeUpdateDto projectTypeUpdateDto);
        Task<IResult> DeleteAsync(int projectTypeId);

        List<ProjectType> GetAllProjectType();
    }
}
