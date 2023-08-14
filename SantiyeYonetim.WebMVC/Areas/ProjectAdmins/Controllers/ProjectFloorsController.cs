using Microsoft.AspNetCore.Mvc;
using SantiyeYonetim.Business.Abstract;
using SantiyeYonetim.WebMVC.Helpers.Abstract;
using SantiyeYonetim.WebMVC.Models.ProjectFloors;
using SantiyeYonetim.WebMVC.Models.Projects;
using System.Threading.Tasks;

namespace SantiyeYonetim.WebMVC.Areas.ProjectAdmins.Controllers
{
    public class ProjectFloorsController : BaseController
    {

        private readonly IProjectFloorService _projectFloorService;
        private readonly IProjectProductionTypeService _projectProductionTypeService;
        private readonly IProductionTypeService _productionTypeService;


        public ProjectFloorsController(IUserAccessor userAccessor, IProjectFloorService projectFloorService, IProjectProductionTypeService projectProductionTypeService, IProductionTypeService productionTypeService) : base(userAccessor)
        {
            _projectFloorService = projectFloorService;
            _projectProductionTypeService = projectProductionTypeService;
            _productionTypeService = productionTypeService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ProjectFloorDetails(int Id)
        {
            var projectProductionType = await _projectProductionTypeService.GetAllAsync();
            var productionType = await _productionTypeService.GetAllAsync();
            var result = await _projectFloorService.GetByIdAsync(Id);
            ViewBag.ProjectResultMessage = result.Message;
            ViewBag.projectId = Id;

            var project = new ProjectFloorDetailViewModel
            {
                ProjectFloor = result.Data,
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
