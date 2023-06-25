using SantiyeYonetim.Core.Utilities.Result.Abstract;
using SantiyeYonetim.Entities.Concrete;
using SantiyeYonetim.Entities.DTOs.Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Business.Abstract
{
    public interface ICompanyService
    {

        Task<IDataResult<Company>> GetByIdAsync(int companyId);

        Task<IDataResult<List<Company>>> GetAllAsync();
        Task<IResult> AddAsync(CompanyAddDto companyAddDto);
        Task<IResult> UpdateAsync(CompanyUpdateDto companyUpdateDto);
        Task<IResult> DeleteAsync(int companyId);

        List<Company> GetCategories();
    }
}
