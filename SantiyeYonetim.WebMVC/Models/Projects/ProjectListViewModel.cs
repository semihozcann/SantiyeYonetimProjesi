using SantiyeYonetim.Entities.Concrete;
using System.Collections.Generic;

namespace SantiyeYonetim.WebMVC.Models.Projects
{
    public class ProjectListViewModel : BaseViewModel
    {
        public List<Project> Projects { get; set; }
    }
}
