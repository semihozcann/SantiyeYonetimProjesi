using SantiyeYonetim.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Entities.Concrete
{
    public class ProjectBlock : BaseEntitiy
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }

        public Project Project { get; set; }
        public List<ProjectFloor> ProjectFloors { get; set; }


    }
}
