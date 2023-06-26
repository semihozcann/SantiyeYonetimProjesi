using AutoMapper;
using SantiyeYonetim.Business.Abstract;
using SantiyeYonetim.Business.Conctants;
using SantiyeYonetim.Core.Utilities.Result.Abstract;
using SantiyeYonetim.Core.Utilities.Result.Concrete;
using SantiyeYonetim.DataAccess.Abstract;
using SantiyeYonetim.Entities.Concrete;
using SantiyeYonetim.Entities.DTOs.ProjectTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Business.Concrete
{
    public class ProjectTypeManager : IProjectTypeService
    {

        IProjectTypeDal _projectTypeDal;
        IMapper _mapper;

        public ProjectTypeManager(IProjectTypeDal projectTypeDal, IMapper mapper)
        {
            _projectTypeDal = projectTypeDal;
            _mapper = mapper;
        }




        public async Task<IResult> AddAsync(ProjectTypeAddDto projectTypeAddDto)
        {
            var projectType = _mapper.Map<ProjectType>(projectTypeAddDto);
            await _projectTypeDal.AddAsync(projectType);
            await _projectTypeDal.SaveAsync();
            return new SuccessResult(Messages.ProjectTypeAdded);
        }

        public async Task<IResult> DeleteAsync(int projectTypeId)
        {
            var projectType = await _projectTypeDal.FindAsync(projectTypeId);
            if (projectType != null)
            {
                await _projectTypeDal.DeleteAsync(projectType);
                await _projectTypeDal.SaveAsync();
                return new SuccessResult(Messages.ProjectTypeDeleted);
            }
            else
            {
                return new ErrorResult(Messages.ProjectTypeNotFound);
            }
        }

        public async Task<IDataResult<List<ProjectType>>> GetAllAsync()
        {
            var projectTypes = await _projectTypeDal.GetAllAsync();
            if (projectTypes != null)
            {
                return new SuccessDataResult<List<ProjectType>>(projectTypes , Messages.ProjectTypeListed);
            }
            else
            {
                return new ErrorDataResult<List<ProjectType>>(null , Messages.ProjectTypeNotFound);
            }
        }

        public async Task<IDataResult<ProjectType>> GetByIdAsync(int projectTypeId)
        {
            var projectType = await _projectTypeDal.FindAsync(projectTypeId);
            if (projectType != null)
            {
                return new SuccessDataResult<ProjectType>(projectType , Messages.ProjectTypeGeted);
            }
            else
            {
                return new ErrorDataResult<ProjectType>(null , Messages.ProjectTypeNotFound);
            }
        }

        public List<ProjectType> GetAllProjectType()
        {
            return _projectTypeDal.GetAll();
        }

        public async Task<IResult> UpdateAsync(ProjectTypeUpdateDto projectTypeUpdateDto)
        {
            var oldProjectType = await _projectTypeDal.GetAsync(p => p.Id == projectTypeUpdateDto.Id);
            if (oldProjectType != null)
            {
                var projectType = _mapper.Map<ProjectTypeUpdateDto, ProjectType>(projectTypeUpdateDto , oldProjectType);
                var updatedProjectType = await _projectTypeDal.UpdateAsync(projectType);
                await _projectTypeDal.SaveAsync();
                return new SuccessResult(Messages.ProjectTypeUpdated);
            }
            else
            {
                return new ErrorResult(Messages.ProjectTypeNotFound);
            }
        }
    }
}
