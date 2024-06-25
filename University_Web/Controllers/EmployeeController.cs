using Microsoft.AspNetCore.Mvc;

namespace University_Web.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        #region Create

        public IActionResult CreateEmployee()
        {
            return View();
        }

        #endregion
    }
}
