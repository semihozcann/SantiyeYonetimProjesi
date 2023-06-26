using AutoMapper;
using SantiyeYonetim.Business.Abstract;
using SantiyeYonetim.Business.Conctants;
using SantiyeYonetim.Core.Utilities.Result.Abstract;
using SantiyeYonetim.Core.Utilities.Result.Concrete;
using SantiyeYonetim.DataAccess.Abstract;
using SantiyeYonetim.Entities.Concrete;
using SantiyeYonetim.Entities.DTOs.ProjectProductionTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Business.Concrete
{
    public class ProjectProductionTypeManager : IProjectProductionTypeService
    {

        IProjectProductionTypeDal _projectProductionTypeDal;
        IMapper _mapper;

        public ProjectProductionTypeManager(IProjectProductionTypeDal projectProductionTypeDal, IMapper mapper)
        {
            _projectProductionTypeDal = projectProductionTypeDal;
            _mapper = mapper;
        }



        public async Task<IResult> AddAsync(ProjectProductionTypeAddDto projectProductionTypeAddDto)
        {
            var projectProductionType = _mapper.Map<ProjectProductionType>(projectProductionTypeAddDto);
            await _projectProductionTypeDal.AddAsync(projectProductionType);
            await _projectProductionTypeDal.SaveAsync();
            return new SuccessResult(Messages.ProjectProductionTypeAdded);
        }

        public async Task<IResult> DeleteAsync(int propjectProductionTypeId)
        {
            var projectProductionType = await _projectProductionTypeDal.FindAsync(propjectProductionTypeId);
            if (projectProductionType != null)
            {
                await _projectProductionTypeDal.DeleteAsync(projectProductionType);
                await _projectProductionTypeDal.SaveAsync();
                return new SuccessResult(Messages.ProjectProductionTypeDeleted);
            }
            else
            {
                return new ErrorResult(Messages.ProjectProductionTypeNotFound);
            }
        }

        public async Task<IDataResult<List<ProjectProductionType>>> GetAllAsync()
        {
            var projectProductionTypes = await _projectProductionTypeDal.GetAllAsync();
            if (projectProductionTypes != null)
            {
                return new SuccessDataResult<List<ProjectProductionType>>(projectProductionTypes , Messages.ProjectProductionTypeListed);
            }
            else
            {
                return new ErrorDataResult<List<ProjectProductionType>>(null , Messages.ProjectProductionTypeNotFound);
            }
        }

        public async Task<IDataResult<ProjectProductionType>> GetByIdAsync(int propjectProductionTypeId)
        {
            var projectProducionType = await _projectProductionTypeDal.FindAsync(propjectProductionTypeId);
            if (projectProducionType != null)
            {
                return new SuccessDataResult<ProjectProductionType>(projectProducionType , Messages.ProjectProductionTypeGeted);
            }
            else
            {
                return new ErrorDataResult<ProjectProductionType>(null , Messages.ProjectProductionTypeNotFound);
            }
        }

        public List<ProjectProductionType> GetAllProjectProductionType()
        {
            return _projectProductionTypeDal.GetAll();
        }

        public async Task<IResult> UpdateAsync(ProjectProductionTypeUpdateDto projectProductionTypeUpdateDto)
        {
            var oldProjectProductionType = await _projectProductionTypeDal.GetAsync(p => p.Id == projectProductionTypeUpdateDto.Id);
            if (oldProjectProductionType != null)
            {
                var projectProductionType = _mapper.Map<ProjectProductionTypeUpdateDto, ProjectProductionType>(projectProductionTypeUpdateDto, oldProjectProductionType);
                var updatedProjectProductionType = await _projectProductionTypeDal.UpdateAsync(projectProductionType);
                await _projectProductionTypeDal.SaveAsync();
                return new SuccessResult(Messages.ProjectProductionTypeUpdated);
            }
            else
            {
                return new ErrorResult(Messages.ProjectProductionTypeNotFound);
            }
        }
    }
}
