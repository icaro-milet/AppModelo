using Microsoft.AspNetCore.Mvc;

namespace MLT.UI.Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
