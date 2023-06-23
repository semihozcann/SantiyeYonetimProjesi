using Microsoft.AspNetCore.Mvc;
using SantiyeYonetim.WebMVC.Helpers.Abstract;

namespace SantiyeYonetim.WebMVC.Areas.ProjectAdmins.Controllers
{
    public class DashboardController : BaseController
    {
        public DashboardController(IUserAccessor userAccessor) : base(userAccessor)
        {
        }

        public IActionResult Index()
        {
            return View();
        }


    }
}
