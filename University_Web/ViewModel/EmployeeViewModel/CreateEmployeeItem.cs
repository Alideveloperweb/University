using System.ComponentModel.DataAnnotations;
using University_Common.ResourceType;

namespace University_Web.ViewModel.EmployeeViewModel
{
    public class CreateEmployeeItem
    {
        /// <summary>
        /// نام 
        /// </summary>
        [Display(ResourceType =typeof(LanguageFa),Name =nameof(LanguageFa.MaritalStatus))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(20, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(3, ErrorMessage = "{0} نمیتواند کمتر از {1}  باشد")]
        public string FirstName { get; set; }

        /// <summary>
        /// نام خانوادگی
        /// </summary>
        [Display(ResourceType = typeof(LanguageFa), Name = nameof(LanguageFa.Family))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(50, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(5, ErrorMessage = "{0} نمیتواند کمتر از {1}  باشد")]
        public string LastName { get; set; }

        /// <summary>
        /// کدملی 
        /// </summary>
        [Display(ResourceType = typeof(LanguageFa), Name = nameof(LanguageFa.NationalCode))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(10, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(10, ErrorMessage = "{0} نمیتواند کمتر از {1}  باشد")]
        public string NationalCode { get; set; }

        /// <summary>
        /// تلفن همراه 
        /// </summary>
        [Display(ResourceType = typeof(LanguageFa), Name = nameof(LanguageFa.Mobile))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(11, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(11, ErrorMessage = "{0} نمیتواند کمتر از {1}  باشد")]
        public string Mobile { get; set; }

        /// <summary>
        /// تلفن خانه  
        /// </summary>
        [Display(ResourceType = typeof(LanguageFa), Name = nameof(LanguageFa.Homephone))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(11, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(11, ErrorMessage = "{0} نمیتواند کمتر از {1}  باشد")]
        public string Homephone { get; set; }

        /// <summary>
        /// ایمیل  
        /// </summary>
        [Display(ResourceType = typeof(LanguageFa), Name = nameof(LanguageFa.Email))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(80, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(5, ErrorMessage = "{0} نمیتواند کمتر از {1}  باشد")]
        public string Email { get; set; }

        /// <summary>
        /// نام کشور  
        /// </summary>
        [Display(ResourceType = typeof(LanguageFa), Name = nameof(LanguageFa.CountryName))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(30, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(8, ErrorMessage = "{0} نمیتواند کمتر از {1}  باشد")]
        public string CountryName { get; set; }

        /// <summary>
        /// نام شهر 
        /// </summary>
        [Display(ResourceType = typeof(LanguageFa), Name = nameof(LanguageFa.CityName))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(90, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(8, ErrorMessage = "{0} نمیتواند کمتر از {1}  باشد")]
        public string CityName { get; set; }

        /// <summary>
        /// آدرس
        /// </summary>
        [Display(ResourceType = typeof(LanguageFa), Name = nameof(LanguageFa.Address))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(20, ErrorMessage = "{0} نمیتواند کمتر از {1}  باشد")]
        public string Address { get; set; }

        /// <summary>
        /// آخرین مدرک تحصیلی
        /// </summary>
        [Display(ResourceType = typeof(LanguageFa), Name = nameof(LanguageFa.LastEducationalCertificate))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(20, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(10, ErrorMessage = "{0} نمیتواند کمتر از {1}  باشد")]
        public string LastEducationalCertificate { get; set; }

        /// <summary>
        /// معدل آخرین مدرک تحصیلی
        /// </summary>
        [Display(ResourceType = typeof(LanguageFa), Name = nameof(LanguageFa.GPAOfThelastDegree))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public double GPAOfThelastDegree { get; set; }

        /// <summary>
        /// جنسیت 
        /// </summary>
        [Display(ResourceType = typeof(LanguageFa), Name = nameof(LanguageFa.Gender))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public bool Gender { get; set; }

        /// <summary>
        /// وضعیت تاهل 
        /// </summary>
        [Display(ResourceType = typeof(LanguageFa), Name = nameof(LanguageFa.MaritalStatus))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public bool MaritalStatus { get; set; }


        /// <summary>
        /// تاریخ تولد 
        /// </summary>
        [Display(ResourceType = typeof(LanguageFa), Name = nameof(LanguageFa.DateOfBirth))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public DateTime DateOfBirth { get; set; }


        /// <summary>
        /// شماره ضروری
        /// </summary>
     
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public string EmergencyContactNumber { get; set; }


        /// <summary>
        /// شماره ملی همسر در صورت متاهل بودن
        /// </summary>
        [Display(Name = "شماره ملی همسر")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public string SpouseNationalID { get; set; }


        /// <summary>
        /// گروه خونی
        /// </summary>
        [Display(Name = "گروه خونی")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public string BloodType { get; set; }


        /// <summary>
        ///سابقه بیماری مهم
        /// </summary>
        [Display(Name = "سابقه بیماری")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public string MedicalHistory { get; set; }

        /// <summary>
        ///  عکس
        /// </summary>
        [Display(Name = "عکس")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public string ImageName { get; set; }

        /// <summary>
        /// شماره کارمندی
        /// </summary>
        [Display(Name = "شماره درسنلی")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public string EmployeeNumber { get; set; }

        /// <summary>
        /// سمت شغلی
        /// </summary>
        [Display(Name = "سمت شغلی")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public string JobTitle { get; set; }

        /// <summary>
        /// بخش
        /// </summary>
        [Display(Name = "بخش")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public string Department { get; set; }

        /// <summary>
        /// تاریخ شروع به کار
        /// </summary>
        [Display(Name = "تاریخ شروع همکاری")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public DateTime HireDate { get; set; }

        /// <summary>
        /// حقوق و دستمزد
        /// </summary>
        [Display(Name = "حقوق")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public decimal Salary { get; set; }

        /// <summary>
        /// وضعیت شغلی (فعال/غیرفعال)
        /// </summary>
        [Display(Name = "وضعیت شغلی (فعال/غیرفعال)")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public bool EmploymentStatus { get; set; }

        /// <summary>
        /// ساعات کاری هفتگی
        /// </summary>
        [Display(Name = "ساعت کاری هفتگی")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public int WeeklyWorkingHours { get; set; }

        /// <summary>
        /// مرخصی‌های باقیمانده
        /// </summary>
        [Display(Name = "مرخضی باقی مانده")]
        public int RemainingLeaveDays { get; set; }

        /// <summary>
        /// مسئول مستقیم
        /// </summary>
        [Display(Name = "مسئول مستقیم")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public string Supervisor { get; set; }

        /// <summary>
        /// مهارت‌ها
        /// </summary>
        [Display(Name = "مهارت ها")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public List<string> Skills { get; set; }

        /// <summary>
        /// گواهینامه‌ها و مدارک حرفه‌ای
        /// </summary>
        [Display(Name = "گواهینامه / مدارک حرفه ای")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public List<string> Certifications { get; set; }

        /// <summary>
        /// ارزیابی عملکرد
        /// </summary>
        [Display(Name = "ارزیابی عملکرد")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public string PerformanceReview { get; set; }

        /// <summary>
        /// پروژه‌های اخیر
        /// </summary>
        [Display(Name = "پروژه ")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public List<string> RecentProjects { get; set; }


        /// <summary>
        /// تکرار کلمه عبور
        /// </summary>
        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public string Password { get; set; }


        /// <summary>
        /// تکرار کلمه عبور
        /// </summary>
        [Display(Name = "تکرار کلمه عبور")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [Compare(nameof(Password), ErrorMessage = "تکرار پسورد با خود پسورد متابقت ندارد .")]
        public string RePassword { get; set; }
    }
}
