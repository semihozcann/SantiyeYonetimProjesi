using Microsoft.AspNetCore.Mvc;
using SantiyeYonetim.Business.Abstract;
using SantiyeYonetim.WebMVC.Helpers.Abstract;
using System.Threading.Tasks;

namespace SantiyeYonetim.WebMVC.Areas.ProjectAdmins.Controllers
{
    public class AutoCreaterController : BaseController
    {

        public AutoCreaterController(IUserAccessor userAccessor) : base(userAccessor)
        {
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
