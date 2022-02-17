using Microsoft.AspNetCore.Mvc;

namespace project.PL.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class FooterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
