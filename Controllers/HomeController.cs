using Microsoft.AspNetCore.Mvc;

namespace project.PL.Controllers
{
    [Route("{controller=Home}/{action=Index}/{id?}")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
