using SantiyeYonetim.Core.Utilities.Result.Abstract;
using SantiyeYonetim.Entities.DTOs.Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Business.Abstract
{
    public interface IAutoCreaterService
    {
        IResult AddAsync(int projectId, int blockNumber , int floorNumber);
    }
}
