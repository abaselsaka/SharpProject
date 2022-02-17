using Microsoft.AspNetCore.Mvc;

namespace project.PL.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class FAQController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
