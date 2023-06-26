using AutoMapper;
using SantiyeYonetim.Business.Abstract;
using SantiyeYonetim.Business.Conctants;
using SantiyeYonetim.Core.Utilities.Result.Abstract;
using SantiyeYonetim.Core.Utilities.Result.Concrete;
using SantiyeYonetim.DataAccess.Abstract;
using SantiyeYonetim.Entities.Concrete;
using SantiyeYonetim.Entities.DTOs.ProductionTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Business.Concrete
{
    public class ProductionTypeManager : IProductionTypeService
    {

        IProductionTypeDal _productionTypeDal;
        IMapper _mapper;

        public ProductionTypeManager(IProductionTypeDal productionTypeDal, IMapper mapper)
        {
            _productionTypeDal = productionTypeDal;
            _mapper = mapper;
        }




        public async Task<IResult> AddAsync(ProductionTypeAddDto productionTypeAddDto)
        {
            var productionType = _mapper.Map<ProductionType>(productionTypeAddDto);
            await _productionTypeDal.AddAsync(productionType);
            await _productionTypeDal.SaveAsync();
            return new SuccessResult(Messages.ProductionTypeAdded);
        }

        public async Task<IResult> DeleteAsync(int productionTypeId)
        {
            var productionType = await _productionTypeDal.FindAsync(productionTypeId);
            if (productionType !=null)
            {
                await _productionTypeDal.DeleteAsync(productionType);
                await _productionTypeDal.SaveAsync();
                return new SuccessResult(Messages.ProductionTypeDeleted);
            }
            else
            {
                return new ErrorResult(Messages.ProductionTypeNotFound);
            }
        }

        public async Task<IDataResult<List<ProductionType>>> GetAllAsync()
        {
            var productionTypes = await _productionTypeDal.GetAllAsync();
            if (productionTypes != null)
            {
                return new SuccessDataResult<List<ProductionType>>(productionTypes, Messages.ProductionTypeListed);
            }
            else
            {
                return new ErrorDataResult<List<ProductionType>>(null, Messages.ProductionTypeNotFound);
            }
        }

        public async Task<IDataResult<ProductionType>> GetByIdAsync(int productionTypeId)
        {
            var production = await _productionTypeDal.FindAsync(productionTypeId);
            if (production != null)
            {
                return new SuccessDataResult<ProductionType>(production, Messages.ProductionTypeGeted);
            }
            else
            {
                return new ErrorDataResult<ProductionType>(null, Messages.ProductionTypeNotFound);
            }
        }

        public List<ProductionType> GetAllProductionType()
        {
            return _productionTypeDal.GetAll();
        }

        public async Task<IResult> UpdateAsync(ProductionTypeUpdateDto productionTypeUpdateDto)
        {
            var oldProductionType = await _productionTypeDal.GetAsync(p => p.Id == productionTypeUpdateDto.Id);
            if (oldProductionType != null)
            {
                var productionType = _mapper.Map<ProductionTypeUpdateDto, ProductionType>(productionTypeUpdateDto, oldProductionType);
                var updatedProductionType = await _productionTypeDal.UpdateAsync(productionType);
                return new SuccessResult(Messages.ProductionTypeUpdated);
            }
            else 
            {
                return new ErrorResult(Messages.ProductionTypeNotFound);
                    
            }

        }
    }
}
