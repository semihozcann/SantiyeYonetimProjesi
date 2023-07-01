using System.ComponentModel.DataAnnotations;

namespace SantiyeYonetim.WebMVC.Models.ProjectBlocks
{
    public class ProjectBlockAddViewModel : BaseViewModel
    {
        [Required(ErrorMessage = "Lütfen Block Adı Giriniz")]
        public string Name { get; set; }
    }
}
