using SantiyeYonetim.Core.DataAccess.Abstract;
using SantiyeYonetim.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.DataAccess.Abstract
{
    public interface IProjectBlockDal : IEntityRepository<ProjectBlock>
    {
        public int GetLastId();
    }
}
