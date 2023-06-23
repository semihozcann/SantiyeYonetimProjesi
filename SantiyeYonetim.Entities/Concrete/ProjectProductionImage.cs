using SantiyeYonetim.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Entities.Concrete
{
    public class ProjectProductionImage : BaseEntitiy
    {
        public int ProjectProductionId { get; set; }
        public string ImageUrl { get; set; }


        public ProjectProduction ProjectProduction { get; set; }




    }
}
