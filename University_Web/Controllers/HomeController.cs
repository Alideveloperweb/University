using Microsoft.AspNetCore.Mvc;

namespace University_Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
