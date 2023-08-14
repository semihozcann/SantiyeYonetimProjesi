using SantiyeYonetim.Entities.Concrete;
using System.Collections.Generic;

namespace SantiyeYonetim.WebMVC.Models.ProjectProductionTypes
{
    public class ProjectProductionTypeDetailViewModel : BaseViewModel
    {
        public List<ProjectProduction> ProjectProductions { get; set; }
    }
}
