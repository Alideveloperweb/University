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

                Employee employee = new(
                    Username: createEmployee.Username,
                    FirstName: createEmployee.FirstName,
                    LastName: createEmployee.LastName,
                    NationalCode: createEmployee.NationalCode,
                    Mobile: createEmployee.Mobile,
                    Homephone: createEmployee.Homephone,
                    CountryName: createEmployee.CountryName,
                    CityName: createEmployee.CityName,
                    Address: createEmployee.Address,
                    LastEducationalCertificate: createEmployee.LastEducationalCertificate,
                    GPAOfThelastDegree: createEmployee.GPAOfThelastDegree,
                    Gender: createEmployee.Gender,
                    MaritalStatus: createEmployee.MaritalStatus,
                    DateOfBirth: createEmployee.DateOfBirth,
                    EmergencyContactNumber: createEmployee.EmergencyContactNumber,
                    SpouseNationalID: createEmployee.SpouseNationalID,
                    BloodType: createEmployee.BloodType, 
                    MedicalHistory: createEmployee.MedicalHistory, 
                    EmployeeNumber: createEmployee.EmployeeNumber,
                    HireDate: createEmployee.HireDate,
                    Salary: createEmployee.Salary,
                    IsActive: createEmployee.IsActive,
                    WeeklyWorkingHours: createEmployee.WeeklyWorkingHours,
                    RemainingLeaveDays: createEmployee.RemainingLeaveDays,
                    Supervisor: createEmployee.Supervisor,
                    /* createEmployee.Skills, createEmployee.Certifications,*/ 
                    PerformanceReview: createEmployee.PerformanceReview, 
                    /*createEmployee.RecentProjects,*/ 
                    Password: createEmployee.Password, DepartmentId: createEmployee.DepartmentId,
                    Email: createEmployee.Email,
                    ImageName: "ali.png",
                    JobId: createEmployee.JobId);


                int save = await _unitOfWork.SaveAsync();
                if (save == 0)
                    return Ok(result.Success(Operation.Success, message.Save()));


                


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
