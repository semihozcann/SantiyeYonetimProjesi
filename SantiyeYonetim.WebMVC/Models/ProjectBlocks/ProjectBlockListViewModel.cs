using SantiyeYonetim.Entities.Concrete;
using System.Collections.Generic;

namespace SantiyeYonetim.WebMVC.Models.ProjectBlocks
{
    public class ProjectBlockListViewModel : BaseViewModel
    {
        public List<ProjectBlock> ProjectBlocks { get; set; }
    }
}
