using SantiyeYonetim.Entities.Concrete;

namespace SantiyeYonetim.WebMVC.Models.Projects
{
    public class ProjectDetailViewModel : BaseViewModel
    {
        public Project Project { get; set; }

        public int ProjectId { get; set; }
        public string ProjectBlockName { get; set; }
    }
}
