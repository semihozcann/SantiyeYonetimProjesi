using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SantiyeYonetim.WebMVC.Models.Projects
{
    public class ProjectUpdateViewModel : BaseViewModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Lütfen Şirketi Seçiniz")]
        public int CompanyId { get; set; }
        [Required(ErrorMessage = "Lütfen Proje Tipini Seçiniz")]
        public int ProjectTypeId { get; set; }
        [Required(ErrorMessage = "Projenin Adını Yazınız")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Proje Açıklaması Yazınız")]
        public string Description { get; set; }

        public List<SelectListItem> CompaniesForDr { get; set; }
        public List<SelectListItem> ProjectTypesForDr { get; set; }
    }
}
