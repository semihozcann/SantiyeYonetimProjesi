using SantiyeYonetim.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiyeYonetim.Entities.Concrete
{
    public class ProjectProduction : BaseEntitiy
    {
        public int ProjectId { get; set; }
        public int ProductionId { get; set; }
        public int ProjectBlockId { get; set; }
        public int ProjectFloorId { get; set; }
        public int ProjectProductionTypeId { get; set; }

        public string DrawingFilePath { get; set; }
        public string AdminNote { get; set; }
        public string UserNote { get; set; }
        public bool CompletionStatus { get; set; } = false;
        public string UpdatedPeople { get; set; }



        public Project Project { get; set; }
        public Production Production { get; set; }
        public ProjectBlock ProjectBlock { get; set; }
        public ProjectFloor ProjectFloor { get; set; }
        public ProjectProductionType ProjectProductionType { get; set; }



        public List<ProjectProductionImage> ProjectProductionImages { get; set; }



    }
}
