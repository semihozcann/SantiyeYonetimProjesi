using Microsoft.AspNetCore.Mvc;
using SantiyeYonetim.WebMVC.Helpers.Abstract;

namespace SantiyeYonetim.WebMVC.Areas.Admins.Controllers
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
