﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using University_Common.Domain;
using University_Domain.EmployeeEntities;
using University_Web.ViewModel.EmployeeViewModel;
using University_Web.Extensions;
using University_Domain.DTO;

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

                // دریافت داده‌ها
                var departments = await _unitOfWork.Department?.Value?.GetSelectList();
                if (departments == null)
                {
                    throw new Exception("داده‌های دپارتمان‌ها یافت نشد.");
                }

                var departmentDtos = departments.Select(d => new SelectListDepartmentDto
                {
                    Id = d.Id,
                    Name = d.Name
                }).ToList();

                var job = await _unitOfWork.Job?.Value?.GetSelectList();
                if (job == null)
                {
                    throw new Exception("داده‌های شغل‌ها یافت نشد.");
                }

                var skills = await _unitOfWork.Skills?.Value?.GetSelectList();
                if (skills == null)
                {
                    throw new Exception("داده‌های مهارت‌ها یافت نشد.");
                }

                var recentProjects = await _unitOfWork.RecentProjects?.Value?.GetSelectList();
                if (recentProjects == null)
                {
                    throw new Exception("داده‌های پروژه‌های اخیر یافت نشد.");
                }

                var certifications = await _unitOfWork.Certifications?.Value?.GetSelectList();
                if (certifications == null)
                {
                    throw new Exception("داده‌های گواهینامه‌ها یافت نشد.");
                }

                // استفاده از متد اکستنشن برای تبدیل به SelectListItem
                createEmployee.Departments = _unitOfWork.Department.Value.ToDepartmentSelectListItems(departmentDtos);
                createEmployee.Jobs = _unitOfWork.Job.Value.ToJobSelectListItems(job);
                createEmployee.Skills = _unitOfWork.Skills.Value.ToSkilsSelectListItems(skills);
                createEmployee.RecentProjects = _unitOfWork.RecentProjects.Value.ToRecentProjectsSelectListItems(recentProjects);
                createEmployee.Certifications = _unitOfWork.Certifications.Value.ToCertificationsSelectListItems(certifications);



                // افزودن آیتم پیش‌فرض به ابتدای هر لیست
                createEmployee.Departments.AddDefaultItem();
                createEmployee.Jobs.AddDefaultItem();
                createEmployee.Skills.AddDefaultItem();
                createEmployee.RecentProjects.AddDefaultItem();
                createEmployee.Certifications.AddDefaultItem();

                return View(createEmployee);
            }
            catch (Exception ex)
            {
                // ثبت خطا در لاگ (در صورت نیاز) و نمایش پیام خطا
                // Log.Error(ex, "خطا در ایجاد کارمند");
                return StatusCode(500, $"خطا: {ex.Message}");
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
                    return BadRequest();
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
                int save = await _unitOfWork.SaveAsync();
                if (save > 0)
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
            if (departments == null)
            {
                throw new Exception("داده‌های دپارتمان‌ها یافت نشد.");
            }

            // تنظیم ViewBag برای دپارتمان‌ها
            ViewBag.Departments = departments.Select(d => new SelectListItem
            {
                Value = d.Id.ToString(),
                Text = d.Name
            }).ToList();

            var job = await _unitOfWork.Job?.Value?.GetSelectList();
            if (job == null)
            {
                throw new Exception("داده‌های دپارتمان‌ها یافت نشد.");
            }

            ViewBag.Job = job.Select(d => new SelectListItem
            {
                Value = d.Id.ToString(),
                Text = d.Title
            }).ToList();

            var skills = await _unitOfWork.Skills?.Value?.GetSelectList();
            if (skills == null)
            {
                throw new Exception("داده‌های دپارتمان‌ها یافت نشد.");
            }

            ViewBag.Skills = skills.Select(d => new SelectListItem
            {
                Value = d.Id.ToString(),
                Text = d.Name
            }).ToList();

            var recentProjects = await _unitOfWork.RecentProjects?.Value?.GetSelectList();
            if (recentProjects == null)
            {
                throw new Exception("داده‌های دپارتمان‌ها یافت نشد.");
            }

            ViewBag.RecentProjects = recentProjects.Select(d => new SelectListItem
            {
                Value = d.Id.ToString(),
                Text = d.Name
            }).ToList();

            var certifications = await _unitOfWork.Certifications?.Value?.GetSelectList();
            if (certifications == null)
            {
                throw new Exception("داده‌های دپارتمان‌ها یافت نشد.");
            }

            ViewBag.Certifications = certifications.Select(d => new SelectListItem
            {
                Value = d.Id.ToString(),
                Text = d.Name
            }).ToList();

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
