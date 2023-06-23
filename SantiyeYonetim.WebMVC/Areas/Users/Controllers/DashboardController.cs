using Microsoft.AspNetCore.Mvc;
using SantiyeYonetim.WebMVC.Helpers.Abstract;
using System.Threading.Tasks;

namespace SantiyeYonetim.WebMVC.Areas.Users.Controllers
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
