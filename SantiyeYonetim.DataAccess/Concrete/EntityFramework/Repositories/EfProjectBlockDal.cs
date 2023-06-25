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
    public class EfProjectBlockDal : BaseEntityRepository<ProjectBlock>, IProjectBlockDal
    {
        public EfProjectBlockDal(DbContext context) : base(context)
        {
        }
    }
}
