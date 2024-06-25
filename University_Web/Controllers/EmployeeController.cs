using Microsoft.AspNetCore.Mvc;
using University_Common.Domain;
using University_Contract.EmployeeViewModel;
using University_Domain.EmployeeEntities;

namespace University_Web.Controllers
{
    public class EmployeeController : Controller
    {

        #region Create

        private readonly IUnitOfWork _unitOfWork;

        public EmployeeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        public IActionResult Index()
        {
          var employees=  _unitOfWork.Employee.Value.GetAllEmployee(false);

            return View(employees);
        }

        #region Create

        [HttpGet]
        public IActionResult CreateEmployee()
        {
          

            return View();
        }

        [HttpPost]
        public IActionResult CreateEmployee(CreateEmployeeItem createEmployee)
        {

          //  Employee employee = new();

            return View();
        }

        #endregion
    }
}
