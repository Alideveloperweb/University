using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using University_Common.Application;
using University_Common.Domain;
using University_Domain.EmployeeEntities;
using University_Web.ViewModel.EmployeeViewModel;

namespace University_Web.Controllers
{
    public class EmployeeController : Controller
    {

        #region Cnstarctor

        private readonly IUnitOfWork _unitOfWork;

        public EmployeeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #endregion

        public IActionResult Index(GetAllEmployeeItem getAllEmployee)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            var employees = _unitOfWork.Employee.Value.AsQueryable().Where(e => e.IsRemove == getAllEmployee.IsRemove);

            GetAllEmployeeItem getEmployee = new GetAllEmployeeItem
            {
                Employees = employees,
            };


            return View(getEmployee);
        }

        #region Create

        [HttpGet]
        public async Task<IActionResult> CreateEmployee()
        {
            // ایجاد یک نمونه از مدل CreateEmployeeItem
            CreateEmployeeItem createEmployee = new CreateEmployeeItem();

          
            if (_unitOfWork == null || _unitOfWork.Department == null || _unitOfWork.Department.Value == null)
            {
                ModelState.AddModelError(string.Empty, "مشکلی در دسترسی به اطلاعات دپارتمان‌ها وجود دارد");
                return View(createEmployee);
            }

            var departments = _unitOfWork.Department.Value.AsQueryable()
                                      .Where(e => !e.IsRemove) 
                                      .ToList();

            // بررسی اگر دپارتمانی وجود نداشته باشد
            if (departments == null || !departments.Any())
            {
                ModelState.AddModelError(string.Empty, "دپارتمانی یافت نشد");
                return View(createEmployee);
            }

            // اختصاص دپارتمان‌ها به ViewBag برای استفاده در View
            ViewBag.Departments = new SelectList(departments, "Id", "Name");


            if (_unitOfWork.Job == null || _unitOfWork.Job.Value == null)
            {
                 ModelState.AddModelError(string.Empty, "مشکلی در دسترسی به اطلاعات سمت‌های شغلی وجود دارد");
                 return View(createEmployee);
             }

             var jobs = _unitOfWork.Job.Value.AsQueryable()
                           .Where(e => !e.IsRemove)
                           .ToList();

             if (jobs == null || !jobs.Any())
             {
                 ModelState.AddModelError(string.Empty, "سمتی یافت نشد");
                 return View(createEmployee);
             }

             ViewBag.Position = new SelectList(jobs, "Id", "Title");

            return View(createEmployee);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeItem createEmployee)
        {
            if (ModelState.IsValid)
            {
                OperationResult result = new();
                ApplicationMessage message = new("کارمند");

                Employee employee = new(createEmployee.FirstName, createEmployee.LastName, createEmployee.NationalCode, createEmployee.Mobile, createEmployee.Homephone, createEmployee.CountryName
                    , createEmployee.CityName, createEmployee.Address, createEmployee.LastEducationalCertificate, createEmployee.GPAOfThelastDegree, createEmployee.Gender, createEmployee.MaritalStatus
                    , createEmployee.DateOfBirth, createEmployee.EmergencyContactNumber, createEmployee.SpouseNationalID, createEmployee.BloodType, createEmployee.MedicalHistory, createEmployee.EmployeeNumber
                    , createEmployee.HireDate, createEmployee.Salary, createEmployee.IsActive, createEmployee.WeeklyWorkingHours, createEmployee.RemainingLeaveDays
                    , createEmployee.Supervisor,/* createEmployee.Skills, createEmployee.Certifications,*/ createEmployee.PerformanceReview, /*createEmployee.RecentProjects,*/ createEmployee.Password);

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

        #region Edit

        [HttpGet]
        public IActionResult EditEmployee()
        {
            return View();
        }

        #endregion

    }
}
