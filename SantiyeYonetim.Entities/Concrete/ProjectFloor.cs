using SantiyeYonetim.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Entities.Concrete
{
    public class ProjectFloor : BaseEntitiy
    {
        public int ProjectBlockId { get; set; }
        public string Name { get; set; }


        public ProjectBlock ProjectBlock { get; set; }
        public List<ProjectProductionType> ProjectProductionTypes { get; set; }


    }
}
