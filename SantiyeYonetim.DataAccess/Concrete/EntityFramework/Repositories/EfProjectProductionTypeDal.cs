using Microsoft.EntityFrameworkCore;
using SantiyeYonetim.Core.DataAccess.Concrete;
using SantiyeYonetim.DataAccess.Abstract;
using SantiyeYonetim.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfProjectProductionTypeDal : BaseEntityRepository<ProjectProductionType>, IProjectProductionTypeDal
    {
        public EfProjectProductionTypeDal(DbContext context) : base(context)
        {
        }

        public int GetLastId()
        {
            using (SantiyeYonetimContext context = new SantiyeYonetimContext())
            {
                var result = from q in context.ProjectProductionTypes
                             orderby q.Id ascending
                             select q.Id;
                return result.Last();
            }


        }
    }
}
