using Microsoft.AspNetCore.Mvc;
using SantiyeYonetim.Business.Abstract;
using SantiyeYonetim.WebMVC.Helpers.Abstract;
using SantiyeYonetim.WebMVC.Models.ProjectFloors;
using SantiyeYonetim.WebMVC.Models.ProjectProductionTypes;
using System.Linq;
using System.Threading.Tasks;

namespace SantiyeYonetim.WebMVC.Areas.ProjectAdmins.Controllers
{
    public class ProjectProductionTypesController : BaseController
    {
        private readonly IProjectProductionTypeService _projectProductionTypeService;
        private readonly IProductionService _productionService;
        private readonly IProductionTypeService _productionTypeService;
        private readonly IProjectProductionService _projectProductionService;

        public ProjectProductionTypesController(IUserAccessor userAccessor, IProjectProductionService projectProductionService, IProjectProductionTypeService projectProductionTypeService, IProductionService productionService, IProductionTypeService productionTypeService) : base(userAccessor)
        {
            _projectProductionService = projectProductionService;
            _projectProductionTypeService = projectProductionTypeService;
            _productionService = productionService;
            _productionTypeService = productionTypeService;
        }

        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> ProjectProductionTypeDetails(int Id)
        {
            var productionType = await _projectProductionService.GetAllAsync();
            var result = await _projectProductionService.GetAllByProjectProductionTypeIdAsync(Id);
            var production = await _productionService.GetAllAsync();
            ViewBag.ProjectResultMessage = result.Message;
            ViewBag.projectId = Id;

            var project = new ProjectProductionTypeDetailViewModel
            {
                ProjectProductions = result.Data,
                Message = result.Message,
            };

            if (result.Success)
            {
                return View(project);
            }
            return View();
        }
    }
}
