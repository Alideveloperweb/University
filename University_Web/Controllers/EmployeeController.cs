using Microsoft.AspNetCore.Mvc;
using University_Common.Application;
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
            if (ModelState.IsValid)
            {
                OperationResult result = new();
                ApplicationMessage message = new("کارمند");

                Employee employee = new(createEmployee.FirstName, createEmployee.LastName,createEmployee.NationalCode,createEmployee.Mobile,createEmployee.Homephone,createEmployee.CountryName
                    ,createEmployee.CityName,createEmployee.Address,createEmployee.LastEducationalCertificate,createEmployee.GPAOfThelastDegree,createEmployee.Gender,createEmployee.MaritalStatus
                    ,createEmployee.DateOfBirth,createEmployee.EmergencyContactNumber,createEmployee.SpouseNationalID,createEmployee.BloodType,createEmployee.MedicalHistory,createEmployee.EmployeeNumber
                    ,createEmployee.JobTitle,createEmployee.Department,createEmployee.HireDate,createEmployee.Salary,createEmployee.EmploymentStatus,createEmployee.WeeklyWorkingHours,createEmployee.RemainingLeaveDays
                    ,createEmployee.Supervisor,createEmployee.Skills,createEmployee.Certifications,createEmployee.PerformanceReview,createEmployee.RecentProjects,createEmployee.Password);

                bool create = _unitOfWork.Employee.Value.Create(employee);
                if (create)
                    return result.Success(Operation.Success, message.Create());


            }
    

            return View();
        }

        #endregion
    }
}
