using Microsoft.AspNetCore.Mvc;
using University_Common.Domain;

namespace University_Web.Controllers
{
    public class UserController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;

        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;                
        }

        public IActionResult Index()
        {
           
            _unitOfWork.Person
            return View();
        }
    }
}
