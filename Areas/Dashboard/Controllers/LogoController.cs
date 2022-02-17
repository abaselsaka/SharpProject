using Microsoft.AspNetCore.Mvc;

namespace project.PL.Controllers
{
    [Area("Dashboard")]
    public class LogoController : Controller
    {
        public IActionResult Edit()
        {
            return View();
        }
    }
}
