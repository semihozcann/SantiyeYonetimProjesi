using AutoMapper;
using SantiyeYonetim.Business.Abstract;
using SantiyeYonetim.Business.Conctants;
using SantiyeYonetim.Core.Utilities.Result.Abstract;
using SantiyeYonetim.Core.Utilities.Result.Concrete;
using SantiyeYonetim.DataAccess.Abstract;
using SantiyeYonetim.Entities.Concrete;
using SantiyeYonetim.Entities.DTOs.Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Business.Concrete
{
    public class CompanyManager : ICompanyService
    {

        #region Injection

        ICompanyDal _companyDal;
        IMapper _mapper;

        public CompanyManager(ICompanyDal companyDal, IMapper mapper)
        {
            _companyDal = companyDal;
            _mapper = mapper;
        }

        #endregion



        public async Task<IResult> AddAsync(CompanyAddDto companyAddDto)
        {
            var company = _mapper.Map<Company>(companyAddDto);
            await _companyDal.AddAsync(company);
            await _companyDal.SaveAsync();
            return new SuccessResult(Messages.CompanyAdded);
        }

        public async Task<IResult> DeleteAsync(int companyId)
        {
            var company = await _companyDal.GetAsync(c => c.Id == companyId);
            if (company != null)
            {
                await _companyDal.DeleteAsync(company);
                await _companyDal.SaveAsync();
                return new SuccessResult(Messages.CompanyDeleted);
            }
            else
            {
                return new ErrorResult(Messages.CompanyNotFound);
            }
        }

        public async Task<IDataResult<List<Company>>> GetAllAsync()
        {
            var companies = await _companyDal.GetAllAsync();
            if (companies != null)
            {
                return new SuccessDataResult<List<Company>>(companies, Messages.CompanyListed);
            }
            else
            {
                return new ErrorDataResult<List<Company>>(null, Messages.CompanyNotFound);
            }
        }

        public async Task<IDataResult<Company>> GetByIdAsync(int companyId)
        {
            var company = await _companyDal.GetAsync(c => c.Id == companyId);
            if (company != null)
            {
                return new SuccessDataResult<Company>(company, Messages.CompanyGeted);
            }
            else
            {
                return new ErrorDataResult<Company>(null, Messages.CompanyNotFound);
            }
        }

        public List<Company> GetAllCompany()
        {
            return _companyDal.GetAll();
        }

        public async Task<IResult> UpdateAsync(CompanyUpdateDto companyUpdateDto)
        {
            var oldCompany = await _companyDal.GetAsync(c => c.Id == companyUpdateDto.Id);
            if (oldCompany != null)
            {
                var company = _mapper.Map<CompanyUpdateDto, Company>(companyUpdateDto, oldCompany);
                var updatedCompany = await _companyDal.UpdateAsync(company);
                await _companyDal.SaveAsync();

                return new SuccessResult(Messages.CompanyUpdated);
            }
            else
            {
                return new ErrorResult(Messages.CompanyNotFound);
            }

        }
    }
}
