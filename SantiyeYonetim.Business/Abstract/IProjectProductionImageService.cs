using SantiyeYonetim.Core.Utilities.Result.Abstract;
using SantiyeYonetim.Entities.Concrete;
using SantiyeYonetim.Entities.DTOs.ProjectProductionImages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Business.Abstract
{
    public interface IProjectProductionImageService
    {
        Task<IDataResult<ProjectProductionImage>> GetByIdAsync(int projectProductionImageId);
        Task<IDataResult<List<ProjectProductionImage>>> GetAllAsync();
        Task<IResult> AddAsync(ProjectProductionImageAddDto projectProductionImageAddDto);
        Task<IResult> UpdateAsync(ProjectProductionImageUpdateDto projectProductionImageUpdateDto);
        Task<IResult> DeleteAsync(int projectProductionImageId);

        List<ProjectProductionImage> GetAllProjectProductionImage();
    }
}
