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

        public IActionResult Index(bool isRemove)
        {
          var employees=  _unitOfWork.Employee.Value.AsQueryable().Where(e=>e.IsRemove==isRemove);

            return View(employees);
        }

        #region Create

        [HttpGet]
        public IActionResult CreateEmployee()
        {
          

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeItem createEmployee)
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
                    return Ok(result.Success(Operation.Success, message.Create()));
                else
                    Ok(result.Failed(Operation.ErrorCreate, message.ErrorCreate()));

                int save = await _unitOfWork.SaveAsync();
                if (save == 0)
                    return Ok(result.Success(Operation.Success, message.Save()));
                else
                    return Ok(result.Failed(Operation.ErrorSave, message.ErrorSave()));

            }
    

            return View();
        }

        #endregion
    }
}
