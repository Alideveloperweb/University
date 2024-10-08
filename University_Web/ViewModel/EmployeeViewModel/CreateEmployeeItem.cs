﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using University_Common.Enum;
using University_Common.ResourceType;


namespace University_Web.ViewModel.EmployeeViewModel
{
    public class CreateEmployeeItem
    {
        [Display(Name = "دپاتمان")]
        public int DepartmentId { get; set; }

        public string? DepartmentName { get; set; } = "";

        public int JobId { get; set; }
        public string? JobTitle { get; set; } = "";

        /// <summary>
        /// نام کاربری 
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.Username))]
        //  [Required(ErrorMessageResourceType = typeof(Language_Fa), ErrorMessageResourceName = nameof(Constants.Validation_Required))]
        //[MaxLength(100, ErrorMessageResourceName = nameof(Constants.UsernameMaxLength), ErrorMessageResourceType = typeof(Language_Fa))]
        //[MinLength(3, ErrorMessageResourceName = nameof(Constants.UsernameMinLength), ErrorMessageResourceType = typeof(Language_Fa))]
        public string? Username { get; set; } = "";

        /// <summary>
        /// نام 
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.Name))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(20, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(3, ErrorMessage = "{0} نمیتواند کمتر از {1}  باشد")]
        public string? FirstName { get; set; } = "";

        /// <summary>
        /// نام خانوادگی
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.Family))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(50, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(5, ErrorMessage = "{0} نمیتواند کمتر از {1}  باشد")]
        public string? LastName { get; set; } = "";

        /// <summary>
        /// کدملی 
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.NationalCode))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(10, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(10, ErrorMessage = "{0} نمیتواند کمتر از {1}  باشد")]
        public string? NationalCode { get; set; } = "";

        /// <summary>
        /// تلفن همراه 
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.Mobile))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(11, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(11, ErrorMessage = "{0} نمیتواند کمتر از {1}  باشد")]
        public string? Mobile { get; set; } = "";

        /// <summary>
        /// تلفن خانه  
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.Homephone))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(11, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(11, ErrorMessage = "{0} نمیتواند کمتر از {1}  باشد")]
        public string? Homephone { get; set; } = "";

        /// <summary>
        /// ایمیل  
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.Email))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(80, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(5, ErrorMessage = "{0} نمیتواند کمتر از {1}  باشد")]
        public string? Email { get; set; } = "";

        /// <summary>
        /// نام کشور  
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.CountryName))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(30, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        public string? CountryName { get; set; } = "";

        /// <summary>
        /// نام شهر 
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.CityName))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(90, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(8, ErrorMessage = "{0} نمیتواند کمتر از {1}  باشد")]
        public string? CityName { get; set; } = "";

        /// <summary>
        /// آدرس
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.Address))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        public string? Address { get; set; } = "";

        /// <summary>
        /// آخرین مدرک تحصیلی
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.LastEducationalCertificate))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(20, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        public string? LastEducationalCertificate { get; set; } = "";

        /// <summary>
        /// معدل آخرین مدرک تحصیلی
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.GPAOfThelastDegree))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public float GPAOfThelastDegree { get; set; }

        /// <summary>
        /// جنسیت     
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.Gender))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public Gender Gender { get; set; }

        /// <summary>
        /// وضعیت تاهل 
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.MaritalStatus))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public MaritalStatus MaritalStatus { get; set; }


        /// <summary>
        /// تاریخ تولد 
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.DateOfBirth))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public DateTime DateOfBirth { get; set; }


        /// <summary>
        /// شماره ضروری
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.EmergencyContactNumber))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public string? EmergencyContactNumber { get; set; } = "";


        /// <summary>
        /// شماره ملی همسر در صورت متاهل بودن
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.SpouseNationalID))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public string? SpouseNationalID { get; set; } = "";


        /// <summary>
        /// گروه خونی
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.BloodType))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public string? BloodType { get; set; } = "";


        /// <summary>
        ///سابقه بیماری مهم
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.MedicalHistory))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public string? MedicalHistory { get; set; } = "";

        /// <summary>
        ///  عکس
        /// </summary>;
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.Image))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public string? ImageName { get; set; } = "ali.png";

        /// <summary>
        /// شماره کارمندی
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.EmployeeNumber))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public string? EmployeeNumber { get; set; } = "c";

        /// <summary>
        /// تاریخ شروع به کار
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.HireDate))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public DateTime HireDate { get; set; }

        /// <summary>
        /// حقوق و دستمزد
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.Salary))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public int Salary { get; set; }

        /// <summary>
        /// وضعیت شغلی (فعال/غیرفعال)
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.EmploymentStatus))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public bool IsActive { get; set; }

        /// <summary>
        /// ساعات کاری هفتگی
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.WeeklyWorkingHours))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public int WeeklyWorkingHours { get; set; }

        /// <summary>
        /// مرخصی‌های باقیمانده
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.RemainingLeaveDays))]
        public int RemainingLeaveDays { get; set; }

        /// <summary>
        /// مسئول مستقیم
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.Supervisor))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public string? Supervisor { get; set; } = "";

        /// <summary>
        /// ارزیابی عملکرد
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.PerformanceReview))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public string? PerformanceReview { get; set; } = "";

        /// <summary>
        ///  کلمه عبور
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.Password))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public string? Password { get; set; } = "";


        /// <summary>
        /// تکرار کلمه عبور
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.RePassword))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [Compare(nameof(Password), ErrorMessage = "تکرار پسورد با خود پسورد متابقت ندارد .")]
        public string? RePassword { get; set; } = "";

        public bool IsRemove { get; set; }

        //[Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.Image))]
        //[Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        //public IFormFile ImageName { get; set; }

        public List<SelectListItem>? Departments { set; get; }
        public List<SelectListItem>? Jobs { set; get; }
        public List<SelectListItem>? Skills { set; get; }
        public List<SelectListItem>? Certifications { set; get; }
        public List<SelectListItem>? RecentProjects { set; get; }
    }
}
