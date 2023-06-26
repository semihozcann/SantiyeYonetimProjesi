using AutoMapper;
using SantiyeYonetim.Business.Abstract;
using SantiyeYonetim.Business.Conctants;
using SantiyeYonetim.Core.Utilities.Result.Abstract;
using SantiyeYonetim.Core.Utilities.Result.Concrete;
using SantiyeYonetim.DataAccess.Abstract;
using SantiyeYonetim.Entities.Concrete;
using SantiyeYonetim.Entities.DTOs.ProjectProductionImages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Business.Concrete
{
    public class ProjectProductionImageManager : IProjectProductionImageService
    {

        IProjectProductionImageDal _projectProductionImageDal;
        IMapper _mapper;

        public ProjectProductionImageManager(IProjectProductionImageDal projectProductionImageDal, IMapper mapper)
        {
            _projectProductionImageDal = projectProductionImageDal;
            _mapper = mapper;
        }



        public async Task<IResult> AddAsync(ProjectProductionImageAddDto projectProductionImageAddDto)
        {
            var projectProductionImage = _mapper.Map<ProjectProductionImage>(projectProductionImageAddDto);
            await _projectProductionImageDal.AddAsync(projectProductionImage);
            await _projectProductionImageDal.SaveAsync();
            return new SuccessResult(Messages.ProjectProductionImageAdded);
        }

        public async Task<IResult> DeleteAsync(int projectProductionImageId)
        {
            var projectProductionImage = await _projectProductionImageDal.FindAsync(projectProductionImageId);
            if (projectProductionImage != null)
            {
                await _projectProductionImageDal.DeleteAsync(projectProductionImage);
                await _projectProductionImageDal.SaveAsync();
                return new SuccessResult(Messages.ProjectProductionImageDeleted);
            }
            else
            {
                return new ErrorResult(Messages.ProjectProductionImageNotFound);
            }
        }

        public async Task<IDataResult<List<ProjectProductionImage>>> GetAllAsync()
        {
            var projectProductionImages = await _projectProductionImageDal.GetAllAsync();
            if (projectProductionImages != null)
            {
                return new SuccessDataResult<List<ProjectProductionImage>>(projectProductionImages , Messages.ProjectProductionImageListed);
            }
            else
            {
                return new ErrorDataResult<List<ProjectProductionImage>>(null, Messages.ProjectProductionImageNotFound);
            }
        }

        public async Task<IDataResult<ProjectProductionImage>> GetByIdAsync(int projectProductionImageId)
        {
            var projectProductionImage = await _projectProductionImageDal.FindAsync(projectProductionImageId);
            if (projectProductionImage != null)
            {
                return new SuccessDataResult<ProjectProductionImage>(projectProductionImage , Messages.ProjectProductionImageGeted);
            }
            else
            {
                return new ErrorDataResult<ProjectProductionImage>(null , Messages.ProjectProductionImageNotFound);
            }
        }

        public List<ProjectProductionImage> GetAllProjectProductionImage()
        {
            return _projectProductionImageDal.GetAll();
        }

        public async Task<IResult> UpdateAsync(ProjectProductionImageUpdateDto projectProductionImageUpdateDto)
        {
            var oldProjectProductionImage = await _projectProductionImageDal.GetAsync(p => p.Id == projectProductionImageUpdateDto.Id);
            if (oldProjectProductionImage != null)
            {
                var projectProductionImage = _mapper.Map<ProjectProductionImageUpdateDto, ProjectProductionImage>(projectProductionImageUpdateDto, oldProjectProductionImage);
                await _projectProductionImageDal.UpdateAsync(projectProductionImage);
                await _projectProductionImageDal.SaveAsync();
                return new SuccessResult(Messages.ProjectProductionImageUpdated);
            }
            else
            {
                return new ErrorResult(Messages.ProjectProductionImageNotFound);
            }
        }
    }
}
