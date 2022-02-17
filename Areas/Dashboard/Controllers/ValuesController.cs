using Microsoft.AspNetCore.Mvc;

namespace project.PL.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class ValuesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
