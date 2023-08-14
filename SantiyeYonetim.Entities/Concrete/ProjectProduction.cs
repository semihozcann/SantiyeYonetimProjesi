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
        public int ProductionId { get; set; }
        public int ProjectProductionTypeId { get; set; }

        public string DrawingFilePath { get; set; }
        public DateTime ProductionStartDate { get; set; }
        public DateTime ProductionEndDate { get; set; }
        public int TotalProductionDays { get; set; }
        public string AdminNote { get; set; }
        public string UserNote { get; set; }
        public bool CompletionStatus { get; set; } = false;
        public string UpdatedPeople { get; set; }



        public Production Production { get; set; }
        public ProjectProductionType ProjectProductionType { get; set; }

        public List<ProjectProductionImage> ProjectProductionImages { get; set; }



    }
}
