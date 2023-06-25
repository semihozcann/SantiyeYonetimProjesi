using SantiyeYonetim.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Entities.Concrete
{
    public class Production : BaseEntitiy
    {
        public int ProductionTypeId { get; set; }
        public int ProductionRowNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public ProductionType ProductionType { get; set; }

    }
}
