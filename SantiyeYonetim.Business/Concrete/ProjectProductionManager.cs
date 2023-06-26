using AutoMapper;
using SantiyeYonetim.Business.Abstract;
using SantiyeYonetim.Business.Conctants;
using SantiyeYonetim.Core.Utilities.Result.Abstract;
using SantiyeYonetim.Core.Utilities.Result.Concrete;
using SantiyeYonetim.DataAccess.Abstract;
using SantiyeYonetim.Entities.Concrete;
using SantiyeYonetim.Entities.DTOs.ProjectProductions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Business.Concrete
{
    public class ProjectProductionManager : IProjectProductionService
    {

        IProjectProductionDal _projectProductionDal;
        IMapper _mapper;

        public ProjectProductionManager(IProjectProductionDal projectProductionDal, IMapper mapper)
        {
            _projectProductionDal = projectProductionDal;
            _mapper = mapper;
        }




        public async Task<IResult> AddAsync(ProjectProductionAddDto projectProductionAddDto)
        {
            var projectProduction = _mapper.Map<ProjectProduction>(projectProductionAddDto);
            await _projectProductionDal.AddAsync(projectProduction);
            await _projectProductionDal.SaveAsync();
            return new SuccessResult(Messages.ProjectProductionAdded);
        }

        public async Task<IResult> DeleteAsync(int projectProductionId)
        {
            var projectProduction = await _projectProductionDal.FindAsync(projectProductionId);
            if (projectProduction == null)
            {
                await _projectProductionDal.DeleteAsync(projectProduction);
                await _projectProductionDal.SaveAsync();
                return new SuccessResult(Messages.ProjectProductionDeleted);
            }
            else
            {
                return new ErrorResult(Messages.ProjectProductionNotFound);
            }
        }

        public async Task<IDataResult<List<ProjectProduction>>> GetAllAsync()
        {
            var projectProductions = await _projectProductionDal.GetAllAsync();
            if (projectProductions != null)
            {
                return new SuccessDataResult<List<ProjectProduction>>(projectProductions , Messages.ProjectProductionListed);
            }
            else
            {
                return new ErrorDataResult<List<ProjectProduction>>(null , Messages.ProjectProductionNotFound);
            }
        }

        public async Task<IDataResult<ProjectProduction>> GetByIdAsync(int projectProductionId)
        {
            var projectProduction = await _projectProductionDal.FindAsync(projectProductionId);
            if (projectProduction == null)
            {
                return new SuccessDataResult<ProjectProduction>(projectProduction , Messages.ProjectProductionGeted);
            }
            else
            {
                return new ErrorDataResult<ProjectProduction>(null , Messages.ProjectProductionNotFound);
            }
        }

        public List<ProjectProduction> GetAllProjectProduction()
        {
            return _projectProductionDal.GetAll();
        }

        public async Task<IResult> UpdateAsync(ProjectProductionUpdateDto projectProductionUpdateDto)
        {
            var oldProjectProduction = await _projectProductionDal.GetAsync(p => p.Id == projectProductionUpdateDto.Id);
            if (oldProjectProduction != null)
            {
                var projectProduction = _mapper.Map<ProjectProductionUpdateDto, ProjectProduction>(projectProductionUpdateDto, oldProjectProduction);
                var updatedProjectProduction = await _projectProductionDal.UpdateAsync(projectProduction);
                await _projectProductionDal.SaveAsync();
                return new SuccessResult(Messages.ProjectProductionUpdated);
            }
            else
            {
                return new ErrorResult(Messages.ProjectProductionNotFound);
            }
        }
    }
}
