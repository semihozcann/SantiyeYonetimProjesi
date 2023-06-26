using SantiyeYonetim.Core.Utilities.Result.Abstract;
using SantiyeYonetim.Entities.Concrete;
using SantiyeYonetim.Entities.DTOs.ProjectBlocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Business.Abstract
{
    public interface IProjectBlockService
    {
        Task<IDataResult<ProjectBlock>> GetByIdAsync(int projectBlockId);
        Task<IDataResult<List<ProjectBlock>>> GetAllAsync();
        Task<IResult> AddAsync(ProjectBlockAddDto projectBlockAddDto);
        Task<IResult> UpdateAsync(ProjectBlockUpdateDto projectBlockUpdateDto);
        Task<IResult> DeleteAsync(int projectBlockId);

        List<ProjectBlock> GetAllProjectBlock();
    }
}
