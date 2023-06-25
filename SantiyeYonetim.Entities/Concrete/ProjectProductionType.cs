using SantiyeYonetim.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Entities.Concrete
{
    public class ProjectProductionType : BaseEntitiy
    {
        public int ProjectFloorId { get; set; }
        public int ProductionTypeId { get; set; }


        public ProductionType ProductionType { get; set; }
        public ProjectFloor ProjectFloor { get; set; }
        public List<Production> Productions { get; set; }



    }
}
