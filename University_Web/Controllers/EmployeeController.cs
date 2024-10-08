﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using University_Common.Domain;
using University_Domain.EmployeeEntities;
using University_Web.ViewModel.EmployeeViewModel;
using University_Web.Extensions;

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

        #region Index
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
        #endregion

        #region Create

        [HttpGet]
        public async Task<IActionResult> CreateEmployee()
        {
            try
            {
                CreateEmployeeItem createEmployee = new CreateEmployeeItem();

                ////// تبدیل DTO ها به SelectListItem ها
                createEmployee.Departments = await _unitOfWork.Department?.Value?.ToDepartmentDtos().ToSelectListItems().AddDefaultItem();
                createEmployee.Jobs = await _unitOfWork.Job?.Value?.SelectListJobsDtos().ToSelectListItems().AddDefaultItem();
                createEmployee.Skills = await _unitOfWork.Skills?.Value?.SelectListSkillsDtos().ToSelectListItems().AddDefaultItem();
                createEmployee.RecentProjects = await _unitOfWork.RecentProjects?.Value?.GetSelectListRecentProjectsDtos().ToSelectListItems().AddDefaultItem();
                createEmployee.Certifications = await _unitOfWork.Certifications?.Value?.SelectListCertificationsDtos().ToSelectListItems().AddDefaultItem();

                return View(createEmployee);
            }
            catch (Exception ex)
            {
                // ثبت خطا در لاگ (در صورت نیاز) و نمایش پیام خطا
                // Log.Error(ex, "خطا در ایجاد کارمند");
               
                return StatusCode(500, "خطایی رخ داده است.");
            }
        }





        [HttpPost]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeItem createEmployee)
        {
            try
            {
                // بررسی اعتبار مدل
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
                    return BadRequest(new { Errors = errors });
                }

                // ایجاد نمونه کارمند
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
                        Skills: createEmployee.Skills.ToSkillList(),
                        PerformanceReview: createEmployee.PerformanceReview,
                        Password: createEmployee.Password,
                        DepartmentId: createEmployee.DepartmentId,
                        Email: createEmployee.Email,
                        ImageName: createEmployee.ImageName,
                        JobId: createEmployee.JobId

                    );

                // اضافه کردن کارمند به واحد کار
                _unitOfWork.Employee.Value.Create(employee);

                // ذخیره تغییرات
                await _unitOfWork.SaveAsync();
                return RedirectToAction("index");

            }
            catch (DbUpdateException dbEx)
            {
                // ثبت و مدیریت استثناهای DbUpdateException
                var sqlEx = dbEx.GetBaseException() as SqlException;
                if (sqlEx != null)
                {
                    // بررسی خطاهای خاص SQL
                    if (sqlEx.Number == 2627) // مثال: خطای یکتایی کلید
                    {
                        return StatusCode(409, "تکراری بودن داده‌ها: " + sqlEx.Message);
                    }
                    // خطای شناخته شده دیگر
                    return StatusCode(500, "خطا در پایگاه داده: " + sqlEx.Message);
                }
                return StatusCode(500, "خطا در پایگاه داده: " + dbEx.Message);
            }
            catch (Exception ex)
            {
                // ثبت و مدیریت سایر استثناها
                return StatusCode(500, "خطای عمومی: " + ex.Message);
            }
        }



        #endregion

        #region Edit

        [HttpGet]
        public async Task<IActionResult> EditEmployee(int Id)
        {
            var employee = _unitOfWork.Employee.Value.Get(Id);

            if (employee == null)
            {
                return NotFound(); // یا می‌توانید به صفحه خطا هدایت کنید
            }

            var viewModel = new EditEmployeeItem
            {
                Id = employee.Id,
                Username = employee.Username,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                NationalCode = employee.NationalCode,
                Mobile = employee.Mobile,
                Homephone = employee.Homephone,
                CountryName = employee.CountryName,
                CityName = employee.CityName,
                Address = employee.Address,
                LastEducationalCertificate = employee.LastEducationalCertificate,
                GPAOfThelastDegree = employee.GPAOfThelastDegree,
                Gender = employee.Gender,
                MaritalStatus = employee.MaritalStatus,
                DateOfBirth = employee.DateOfBirth,
                EmergencyContactNumber = employee.EmergencyContactNumber,
                SpouseNationalID = employee.SpouseNationalID,
                BloodType = employee.BloodType,
                MedicalHistory = employee.MedicalHistory,
                EmployeeNumber = employee.EmployeeNumber,
                HireDate = employee.HireDate,
                Salary = employee.Salary,
                IsActive = employee.IsActive,
                WeeklyWorkingHours = employee.WeeklyWorkingHours,
                RemainingLeaveDays = employee.RemainingLeaveDays,
                Supervisor = employee.Supervisor,
                PerformanceReview = employee.PerformanceReview,
                Email = employee.Email,
                JobId = employee.JobId
            };

            var departments = await _unitOfWork.Department?.Value?.GetSelectList();

            var job = await _unitOfWork.Job?.Value?.GetSelectList();

            var skills = await _unitOfWork.Skills?.Value?.GetSelectList();

            var recentProjects = await _unitOfWork.RecentProjects?.Value?.GetSelectList();

            var certifications = await _unitOfWork.Certifications?.Value?.GetSelectList();

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> EditEmployee(EditEmployeeItem editEmployeeItem)
        {
            try
            {
                // بررسی اعتبار مدل
                //if (!ModelState.IsValid)
                //{
                //    return View(createEmployee);
                //}

                // ایجاد نمونه کارمند

                Employee employee = _unitOfWork.Employee.Value.Get(editEmployeeItem.Id);

                employee.Edit(
                    Username: editEmployeeItem.Username,
                    FirstName: editEmployeeItem.FirstName,
                    LastName: editEmployeeItem.LastName,
                    NationalCode: editEmployeeItem.NationalCode,
                    Mobile: editEmployeeItem.Mobile,
                    Homephone: editEmployeeItem.Homephone,
                    CountryName: editEmployeeItem.CountryName,
                    CityName: editEmployeeItem.CityName,
                    Address: editEmployeeItem.Address,
                    LastEducationalCertificate: editEmployeeItem.LastEducationalCertificate,
                    GPAOfThelastDegree: editEmployeeItem.GPAOfThelastDegree,
                    Gender: editEmployeeItem.Gender,
                    MaritalStatus: editEmployeeItem.MaritalStatus,
                    DateOfBirth: editEmployeeItem.DateOfBirth,
                    EmergencyContactNumber: editEmployeeItem.EmergencyContactNumber,
                    SpouseNationalID: editEmployeeItem.SpouseNationalID,
                    BloodType: editEmployeeItem.BloodType,
                    MedicalHistory: editEmployeeItem.MedicalHistory,
                    EmployeeNumber: editEmployeeItem.EmployeeNumber,
                    HireDate: editEmployeeItem.HireDate,
                    Salary: editEmployeeItem.Salary,
                    IsActive: editEmployeeItem.IsActive,
                    WeeklyWorkingHours: editEmployeeItem.WeeklyWorkingHours,
                    RemainingLeaveDays: editEmployeeItem.RemainingLeaveDays,
                    Supervisor: editEmployeeItem.Supervisor,
                    PerformanceReview: editEmployeeItem.PerformanceReview,
                    Password: editEmployeeItem.Password,
                    DepartmentId: 1,
                    Email: editEmployeeItem.Email,
                    ImageName: "ali.png",
                    JobId: editEmployeeItem.JobId
                );

                // اضافه کردن کارمند به واحد کار
                _unitOfWork.Employee.Value.Update(employee);

                // ذخیره تغییرات
                int save = await _unitOfWork.SaveAsync();
                if (save != 0)
                {
                    return Ok(new { Success = true, Message = "کارمند با موفقیت ذخیره شد." });
                }
                else
                {
                    return StatusCode(500, "عملیات ذخیره‌سازی با شکست مواجه شد.");
                }
            }
            catch (DbUpdateException dbEx)
            {
                // ثبت و مدیریت استثناهای DbUpdateException
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
                // ثبت و مدیریت سایر استثناها
                return StatusCode(500, ex.Message);
            }
        }

        #endregion

        #region Delete

        [HttpGet]
        // !todo convert to ajax after implement list
        public async Task<IActionResult> DeleteEmployee(int Id)
        {
            Employee employee = _unitOfWork.Employee.Value.Get(Id);

            employee.Remove();
            await _unitOfWork.SaveAsync();
            return RedirectToAction("index");
        }

        #endregion
    }
}
