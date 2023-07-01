using System.ComponentModel.DataAnnotations;

namespace SantiyeYonetim.WebMVC.Models.ProjectBlocks
{
    public class ProjectBlockUpdateViewModel : BaseViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Lütfen Şirketi Seçiniz")]
        public int ProjectId { get; set; }
        [Required(ErrorMessage = "Lütfen Block Adı Giriniz")]
        public string Name { get; set; }
    }
}
