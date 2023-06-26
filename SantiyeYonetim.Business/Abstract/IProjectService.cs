using SantiyeYonetim.Core.Utilities.Result.Abstract;
using SantiyeYonetim.Entities.Concrete;
using SantiyeYonetim.Entities.DTOs.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Business.Abstract
{
    public interface IProjectService
    {
        Task<IDataResult<Project>> GetByIdAsync(int projectId);
        Task<IDataResult<List<Project>>> GetAllAsync();
        Task<IResult> AddAsync(ProjectAddDto projectAddDto);
        Task<IResult> UpdateAsync(ProjectUpdateDto projectUpdateDto);
        Task<IResult> DeleteAsync(int projectId);

        List<Project> GetAllProject();
    }
}
