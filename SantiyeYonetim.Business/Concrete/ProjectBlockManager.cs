using AutoMapper;
using SantiyeYonetim.Business.Abstract;
using SantiyeYonetim.Business.Conctants;
using SantiyeYonetim.Core.Utilities.Result.Abstract;
using SantiyeYonetim.Core.Utilities.Result.Concrete;
using SantiyeYonetim.DataAccess.Abstract;
using SantiyeYonetim.Entities.Concrete;
using SantiyeYonetim.Entities.DTOs.ProjectBlocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Business.Concrete
{
    public class ProjectBlockManager : IProjectBlockService
    {

        IProjectBlockDal _projectBlockDal;
        IMapper _mapper;

        public ProjectBlockManager(IProjectBlockDal projectBlockDal, IMapper mapper)
        {
            _projectBlockDal = projectBlockDal;
            _mapper = mapper;
        }




        public async Task<IResult> AddAsync(ProjectBlockAddDto projectBlockAddDto)
        {
            var projectBlock = _mapper.Map<ProjectBlock>(projectBlockAddDto);
            await _projectBlockDal.AddAsync(projectBlock);
            await _projectBlockDal.SaveAsync();
            return new SuccessResult(Messages.ProjectBlockAdded);
        }

        public async Task<IResult> DeleteAsync(int projectBlockId)
        {
            var projectBlock = await _projectBlockDal.FindAsync(projectBlockId);
            if (projectBlock != null)
            {
                await _projectBlockDal.DeleteAsync(projectBlock);
                await _projectBlockDal.SaveAsync();
                return new SuccessResult(Messages.ProjectBlockDeleted);
            }
            else
            {
                return new ErrorResult(Messages.ProjectBlockNotFound);
            }
        }

        public async Task<IDataResult<List<ProjectBlock>>> GetAllAsync()
        {
            var projectBlocks = await _projectBlockDal.GetAllAsync();
            if (projectBlocks != null)
            {
                return new SuccessDataResult<List<ProjectBlock>>(projectBlocks, Messages.ProjectBlockListed);
            }
            else
            {
                return new ErrorDataResult<List<ProjectBlock>>(null , Messages.ProjectBlockNotFound);
            }
        }

        public async Task<IDataResult<ProjectBlock>> GetByIdAsync(int projectBlockId)
        {
            var projectBlock = await _projectBlockDal.GetAsync(p => p.Id == projectBlockId);
            if (projectBlock != null)
            {
                return new SuccessDataResult<ProjectBlock>(projectBlock, Messages.ProjectBlockGeted);
            }
            else
            {
                return new ErrorDataResult<ProjectBlock>(null , Messages.ProjectBlockNotFound);
            }
        }

        public List<ProjectBlock> GetAllProjectBlock()
        {
            return _projectBlockDal.GetAll();
        }

        public async Task<IResult> UpdateAsync(ProjectBlockUpdateDto projectBlockUpdateDto)
        {
            var oldProjectBlock = await _projectBlockDal.GetAsync(p => p.Id == projectBlockUpdateDto.Id);
            if (oldProjectBlock != null)
            {
                var projectBlock = _mapper.Map<ProjectBlockUpdateDto, ProjectBlock>(projectBlockUpdateDto, oldProjectBlock);
                var updatedProjectBlock = await _projectBlockDal.UpdateAsync(projectBlock);
                await _projectBlockDal.SaveAsync();
                return new SuccessResult(Messages.ProjectBlockUpdated);
            }
            else
            {
                return new ErrorResult(Messages.ProjectBlockNotFound);
            }

        }


        public int LastId()
        {
            return _projectBlockDal.GetLastId();
        }
    }
}
