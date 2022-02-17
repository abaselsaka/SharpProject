using Microsoft.AspNetCore.Mvc;

namespace project.PL.Controllers
{
    [Area("Dashboard")]
    public class NavController : Controller
    {
        public IActionResult Edit()
        {
            return View();
        }
    }
}
