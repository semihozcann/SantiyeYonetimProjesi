using AutoMapper;
using SantiyeYonetim.Business.Abstract;
using SantiyeYonetim.Business.Conctants;
using SantiyeYonetim.Core.Utilities.Result.Abstract;
using SantiyeYonetim.Core.Utilities.Result.Concrete;
using SantiyeYonetim.DataAccess.Abstract;
using SantiyeYonetim.Entities.Concrete;
using SantiyeYonetim.Entities.DTOs.Producions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Business.Concrete
{
    public class ProductionManager : IProductionService
    {

        IProductionDal _productionDal;
        IMapper _mapper;

        public ProductionManager(IProductionDal productionDal, IMapper mapper)
        {
            _productionDal = productionDal;
            _mapper = mapper;
        }




        public async Task<IResult> AddAsync(ProductionAddDto productionAddDto)
        {
            var production = _mapper.Map<Production>(productionAddDto);
            await _productionDal.AddAsync(production);
            await _productionDal.SaveAsync();
            return new SuccessResult(Messages.ProductionAdded);
        }

        public async Task<IResult> DeleteAsync(int productionId)
        {
            var production = await _productionDal.GetAsync(p => p.Id == productionId);
            if (production != null)
            {
                await _productionDal.DeleteAsync(production);
                await _productionDal.SaveAsync();
                return new SuccessResult(Messages.ProductionDeleted);
            }
            else
            {
                return new ErrorResult(Messages.ProductionNotFound);
            }
        }

        public async Task<IDataResult<List<Production>>> GetAllAsync()
        {
            var productions = await _productionDal.GetAllAsync();
            if (productions != null)
            {
                return new SuccessDataResult<List<Production>>(productions , Messages.ProductionListed);
            }
            else
            {
                return new ErrorDataResult<List<Production>>(null , Messages.ProductionNotFound);
            }
        }

        public async Task<IDataResult<Production>> GetByIdAsync(int productionId)
        {
            var production = await _productionDal.GetAsync(p => p.Id == productionId);
            if (production != null)
            {
                return new SuccessDataResult<Production>(production, Messages.ProductionGeted);
            }
            else
            {
                return new ErrorDataResult<Production>(null , Messages.ProductionNotFound);
            }
        }

        public List<Production> GetAllProduction()
        {
            return _productionDal.GetAll();
        }

        public async Task<IResult> UpdateAsync(ProductionUpdateDto productionUpdateDto)
        {
            var oldProduction = await _productionDal.GetAsync(p => p.Id == productionUpdateDto.Id);
            if (oldProduction != null)
            {
                var production = _mapper.Map<ProductionUpdateDto, Production>(productionUpdateDto, oldProduction);
                var updatedProduction = await _productionDal.UpdateAsync(production);
                await _productionDal.SaveAsync();
                return new SuccessResult(Messages.ProductionUpdated);
            }
            else
            {
                return new ErrorResult(Messages.ProductionNotFound);
            }
        }
    }
}
