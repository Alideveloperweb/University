using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
                //create model
                //add model to database
                    //create connection
                        //create socket network
                        //send hello handshake
                        //send data to port xxx
                    //create sqlcommand
                    //create queury string
                    //create parameters
                    //run query
                    
                
                    
                
                
                
                CreateEmployeeItem createEmployee = new CreateEmployeeItem();
                
                
                

                var departments = await _unitOfWork.Department?.Value?.GetSelectList();
                if (departments == null)
                {
                    throw new Exception("داده‌های دپارتمان‌ها یافت نشد.");
                }

                // تنظیم ViewBag برای دپارتمان‌ها
                // !Todo use mapper or extenision method for convert dto to SelectListItem
                createEmployee.Departments = departments.Select(d => new SelectListItem
                {
                    Value = d.Id.ToString(),
                    Text = d.Name
                }).ToList();
                
                // !Todo Convert it to extension method
                createEmployee.Departments.Insert(0,new SelectListItem()
                {
                    Text = "انتخاب کنید",
                    Value = ""
                });

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
                //if (!ModelState.IsValid)
                //{
                //    return View(createEmployee);
                //}

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
                    DepartmentId: 1,
                    Email: createEmployee.Email,
                    ImageName: "ali.png",
                    JobId: createEmployee.JobId
                );

                // اضافه کردن کارمند به واحد کار
                _unitOfWork.Employee.Value.Create(employee);

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
                //!todo check exception message and return correct status code depend to message
                // username in employee is index unique
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
