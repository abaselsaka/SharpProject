using Microsoft.AspNetCore.Mvc;

namespace project.PL.Controllers
{
    [Area("FlexTemp")]
    public class FlexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Portfolio()
        {
            return View();
        }
    }
}
