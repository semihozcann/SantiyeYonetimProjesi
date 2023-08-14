using AutoMapper;
using SantiyeYonetim.Business.Abstract;
using SantiyeYonetim.Business.Conctants;
using SantiyeYonetim.Core.Utilities.Result.Abstract;
using SantiyeYonetim.Core.Utilities.Result.Concrete;
using SantiyeYonetim.DataAccess.Abstract;
using SantiyeYonetim.DataAccess.Concrete.EntityFramework.Repositories;
using SantiyeYonetim.Entities.Concrete;
using SantiyeYonetim.Entities.DTOs.ProjectFloors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Business.Concrete
{
    public class ProjectFloorManager : IProjectFloorService
    {

        IProjectFloorDal _projectFloorDal;
        IMapper _mapper;

        public ProjectFloorManager(IProjectFloorDal projectFloorDal, IMapper mapper)
        {
            _projectFloorDal = projectFloorDal;
            _mapper = mapper;
        }




        public async Task<IResult> AddAsync(ProjectFloorAddDto projectFloorAddDto)
        {
            var projectFloor = _mapper.Map<ProjectFloor>(projectFloorAddDto);
            await _projectFloorDal.AddAsync(projectFloor);
            await _projectFloorDal.SaveAsync();
            return new SuccessResult(Messages.ProjectFloorAdded);
        }

        public async Task<IResult> DeleteAsync(int projectFloorId)
        {
            var projectFloor = await _projectFloorDal.FindAsync(projectFloorId);
            if (projectFloor != null)
            {
                await _projectFloorDal.DeleteAsync(projectFloor);
                await _projectFloorDal.SaveAsync();
                return new SuccessResult(Messages.ProjectFloorDeleted);
            }
            else
            {
                return new ErrorResult(Messages.ProjectFloorNotFound);
            }
        }

        public async Task<IDataResult<List<ProjectFloor>>> GetAllAsync()
        {
            var projectFloors = await _projectFloorDal.GetAllAsync();
            if (projectFloors != null)
            {
                return new SuccessDataResult<List<ProjectFloor>>(projectFloors, Messages.ProjectFloorListed);
            }
            else
            {
                return new ErrorDataResult<List<ProjectFloor>>(null , Messages.ProjectFloorNotFound);
            }
        }

        public async Task<IDataResult<ProjectFloor>> GetByIdAsync(int projectFloorId)
        {
            var projectFloor = await _projectFloorDal.GetAsync(p =>p.Id == projectFloorId);
            if (projectFloor != null)
            {
                return new SuccessDataResult<ProjectFloor>(projectFloor, Messages.ProjectFloorGeted);
            }
            else
            {
                return new ErrorDataResult<ProjectFloor>(null, Messages.ProjectFloorNotFound);
            }
        }

        public List<ProjectFloor> GetAllProjectFloor()
        {
            return _projectFloorDal.GetAll();
        }

        public async Task<IResult> UpdateAsync(ProjectFloorUpdateDto projectFloorUpdateDto)
        {
            var oldProjectFloor = await _projectFloorDal.GetAsync(p => p.Id == projectFloorUpdateDto.Id);
            if (oldProjectFloor != null)
            {
                var projectFloor = _mapper.Map<ProjectFloorUpdateDto, ProjectFloor>(projectFloorUpdateDto, oldProjectFloor);
                await _projectFloorDal.UpdateAsync(projectFloor);
                await _projectFloorDal.SaveAsync();
                return new SuccessResult(Messages.ProjectFloorUpdated);
            }
            else
            {
                return new ErrorResult(Messages.ProjectFloorNotFound);
            }
        }

        public int LastId()
        {
            return _projectFloorDal.GetLastId();
        }
    }
}
