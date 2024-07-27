using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
        private readonly IMapper _mapper;

        public EmployeeController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        #endregion

        public IActionResult Index(GetAllEmployeeItem getAllEmployee)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            var employees = _unitOfWork.Employee.Value.GetAllRemove(getAllEmployee.IsRemove);

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

            try
            {
                // ایجاد یک نمونه از مدل CreateEmployeeItem
                CreateEmployeeItem createEmployee = new CreateEmployeeItem();

                createEmployee.Departments = await _unitOfWork.Department.Value.GetSelectList();
                
                createEmployee.Jobs = await _unitOfWork.Job.Value.GetSelectList().ToList();
                
                createEmployee.Skills = await _unitOfWork.Skills.Value.GetSelectList().ToList();
                
                createEmployee.RecentProjects = await _unitOfWork.RecentProjects.Value.GetSelectList().ToList();
                
                createEmployee.Certifications = await _unitOfWork.Certifications.Value.GetSelectList().ToList();
              
                if (createEmployee.Certifications.Text.Any())
                {
                    ModelState.AddModelError(string.Empty, "مدرکی یافت نشد");
                    return View(createEmployee);
                }

   

                return View(createEmployee);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeItem createEmployee)
        {
            try
            {


                //if (ModelState.IsValid)
                //{
                OperationResult result = new();
                ApplicationMessage message = new("کارمند");

                Employee employee = new(createEmployee.Username, createEmployee.FirstName, createEmployee.LastName, createEmployee.NationalCode, createEmployee.Mobile, createEmployee.Homephone, createEmployee.CountryName
                    , createEmployee.CityName, createEmployee.Address, createEmployee.LastEducationalCertificate, createEmployee.GPAOfThelastDegree, createEmployee.Gender, createEmployee.MaritalStatus
                    , createEmployee.DateOfBirth, createEmployee.EmergencyContactNumber, createEmployee.SpouseNationalID, createEmployee.BloodType, createEmployee.MedicalHistory, createEmployee.EmployeeNumber
                    , createEmployee.HireDate, createEmployee.Salary, createEmployee.IsActive, createEmployee.WeeklyWorkingHours, createEmployee.RemainingLeaveDays
                    , createEmployee.Supervisor,/* createEmployee.Skills, createEmployee.Certifications,*/ createEmployee.PerformanceReview, /*createEmployee.RecentProjects,*/ createEmployee.Password, createEmployee.DepartmentId, createEmployee.Email, "ali.png", createEmployee.JobId);


                var departments = _unitOfWork.Department.Value.AsQueryable().Where(e => !e.IsRemove).ToList();
                ViewBag.Departments = new SelectList(departments, "Id", "Name");

                var jobs = _unitOfWork.Job.Value.AsQueryable().Where(e => !e.IsRemove).ToList();
                ViewBag.Position = new SelectList(jobs, "Id", "Title");

                var certification = _unitOfWork.Certifications.Value.AsQueryable().Where(e => !e.IsRemove).ToList();
                ViewBag.Certifications = new SelectList(certification, "Id", "Name");

                var recentProjects = _unitOfWork.RecentProjects.Value.AsQueryable().Where(e => !e.IsRemove).ToList();
                ViewBag.RecentProjects = new SelectList(recentProjects, "Id", "Name");

                var skills = _unitOfWork.Skills.Value.AsQueryable().Where(e => !e.IsRemove).ToList();
                ViewBag.Skills = new SelectList(skills, "Id", "Name");

                bool createCertification = _unitOfWork.Certifications.Value.CreateRenge(certification);

                bool create = _unitOfWork.Employee.Value.Create(employee);
                if (!create)
                    return Ok(result.Success(Operation.Success, message.Create()));
                else
                    Ok(result.Failed(Operation.ErrorCreate, message.ErrorCreate()));

                int save = await _unitOfWork.SaveAsync();
                if (save == 0)
                    return Ok(result.Success(Operation.Success, message.Save()));


                //}


            }
            catch (DbUpdateException dbEx)
            {
                // Log and handle DbUpdateException
                var sqlEx = dbEx.GetBaseException() as SqlException;
                if (sqlEx != null)
                {
                    if (sqlEx.Number == 544) // Error number for IDENTITY_INSERT issue
                    {
                        return StatusCode(500, "Cannot insert explicit value for identity column when IDENTITY_INSERT is set to OFF.");
                    }
                }
                return StatusCode(500, dbEx.Message);
            }
            catch (Exception ex)
            {
                // Log and handle other exceptions
                return StatusCode(500, ex.Message);
            }

            return View(createEmployee);
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
