using AutoMapper;
using SantiyeYonetim.Business.Abstract;
using SantiyeYonetim.Business.Conctants;
using SantiyeYonetim.Core.Utilities.Result.Abstract;
using SantiyeYonetim.Core.Utilities.Result.Concrete;
using SantiyeYonetim.DataAccess.Abstract;
using SantiyeYonetim.Entities.Concrete;
using SantiyeYonetim.Entities.DTOs.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Business.Concrete
{
    public class ProjectManager : IProjectService
    {

        IProjectDal _projectDal;
        IMapper _mapper;

        public ProjectManager(IProjectDal projectDal, IMapper mapper)
        {
            _projectDal = projectDal;
            _mapper = mapper;
        }




        public async Task<IResult> AddAsync(ProjectAddDto projectAddDto)
        {
            var project = _mapper.Map<Project>(projectAddDto);
            await _projectDal.AddAsync(project);
            await _projectDal.SaveAsync();
            return new SuccessResult(Messages.ProjectAdded);
        }

        public async Task<IResult> DeleteAsync(int projectId)
        {
            var project = await _projectDal.FindAsync(projectId);
            if (project != null)
            {
                await _projectDal.DeleteAsync(project);
                await _projectDal.SaveAsync();
                return new SuccessResult(Messages.ProjectDeleted);
            }
            else
            {
                return new ErrorResult(Messages.ProjectNotFound);
            }
        }

        public async Task<IDataResult<List<Project>>> GetAllAsync()
        {
            var projects = await _projectDal.GetAllAsync();
            if (projects != null)
            {
                return new SuccessDataResult<List<Project>>(projects , Messages.ProjectListed);
            }
            else
            {
                return new ErrorDataResult<List<Project>>(null , Messages.ProjectNotFound);
            }
        }

        public async Task<IDataResult<Project>> GetByIdAsync(int projectId)
        {
            var project = await _projectDal.FindAsync(projectId);
            if (project != null)
            {
                return new SuccessDataResult<Project>(project , Messages.ProjectGeted);
            }
            else
            {
                return new ErrorDataResult<Project>(null , Messages.ProjectNotFound);
            }
        }

        public List<Project> GetAllProject()
        {
            return _projectDal.GetAll();
        }

        public async Task<IResult> UpdateAsync(ProjectUpdateDto projectUpdateDto)
        {
            var oldProject = await _projectDal.GetAsync(p => p.Id == projectUpdateDto.Id);
            if (oldProject != null)
            {
                var project = _mapper.Map<ProjectUpdateDto, Project>(projectUpdateDto, oldProject);
                await _projectDal.UpdateAsync(project);
                await _projectDal.SaveAsync();
                return new SuccessResult(Messages.ProjectUpdated);
            }
            else
            {
                return new ErrorResult(Messages.ProjectNotFound);
            }
        }
    }
}
