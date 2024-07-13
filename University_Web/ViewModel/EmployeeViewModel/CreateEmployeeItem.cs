using System.ComponentModel.DataAnnotations;
using University_Common.ResourceType;
using University_Domain.EmployeeEntities;


namespace University_Web.ViewModel.EmployeeViewModel
{
    public class CreateEmployeeItem
    {

        public int DepartmentId { get; set; }

        public int JobId { get; set; }

        /// <summary>
        /// نام کاربری 
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.Username))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(20, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(3, ErrorMessage = "{0} نمیتواند کمتر از {1}  باشد")]
        public string Username { get; set; }

        /// <summary>
        /// نام 
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.Name))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(20, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(3, ErrorMessage = "{0} نمیتواند کمتر از {1}  باشد")]
        public string FirstName { get; set; }

        /// <summary>
        /// نام خانوادگی
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.Family))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(50, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(5, ErrorMessage = "{0} نمیتواند کمتر از {1}  باشد")]
        public string LastName { get; set; }

        /// <summary>
        /// کدملی 
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.NationalCode))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(10, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(10, ErrorMessage = "{0} نمیتواند کمتر از {1}  باشد")]
        public string NationalCode { get; set; }

        /// <summary>
        /// تلفن همراه 
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.Mobile))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(11, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(11, ErrorMessage = "{0} نمیتواند کمتر از {1}  باشد")]
        public string Mobile { get; set; }

        /// <summary>
        /// تلفن خانه  
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.Homephone))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(11, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(11, ErrorMessage = "{0} نمیتواند کمتر از {1}  باشد")]
        public string Homephone { get; set; }

        /// <summary>
        /// ایمیل  
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.Email))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(80, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(5, ErrorMessage = "{0} نمیتواند کمتر از {1}  باشد")]
        public string Email { get; set; }

        /// <summary>
        /// نام کشور  
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.CountryName))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(30, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(8, ErrorMessage = "{0} نمیتواند کمتر از {1}  باشد")]
        public string CountryName { get; set; }

        /// <summary>
        /// نام شهر 
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.CityName))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(90, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(8, ErrorMessage = "{0} نمیتواند کمتر از {1}  باشد")]
        public string CityName { get; set; }

        /// <summary>
        /// آدرس
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.Address))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(20, ErrorMessage = "{0} نمیتواند کمتر از {1}  باشد")]
        public string Address { get; set; }

        /// <summary>
        /// آخرین مدرک تحصیلی
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.LastEducationalCertificate))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [MaxLength(20, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد")]
        [MinLength(10, ErrorMessage = "{0} نمیتواند کمتر از {1}  باشد")]
        public string LastEducationalCertificate { get; set; }

        /// <summary>
        /// معدل آخرین مدرک تحصیلی
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.GPAOfThelastDegree))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public double GPAOfThelastDegree { get; set; }

        /// <summary>
        /// جنسیت     
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.Gender))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public bool Gender { get; set; }

        /// <summary>
        /// وضعیت تاهل 
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.MaritalStatus))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public bool MaritalStatus { get; set; }


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
        public string EmergencyContactNumber { get; set; }


        /// <summary>
        /// شماره ملی همسر در صورت متاهل بودن
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.SpouseNationalID))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public string SpouseNationalID { get; set; }


        /// <summary>
        /// گروه خونی
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.BloodType))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public string BloodType { get; set; }


        /// <summary>
        ///سابقه بیماری مهم
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.MedicalHistory))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public string MedicalHistory { get; set; }

        /// <summary>
        ///  عکس
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.Image))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public string ImageName { get; set; }

        /// <summary>
        /// شماره کارمندی
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.EmployeeNumber))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public string EmployeeNumber { get; set; }

        /// <summary>
        /// سمت شغلی
        /// </summary>
        //[Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.JobTitle))]
        //[Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        //public string JobTitle { get; set; }

        /// <summary>
        /// بخش
        /// </summary>
        //[Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.Department))]
        //[Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        //public string Department { get; set; }

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
        public decimal Salary { get; set; }

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
        public string Supervisor { get; set; }

        /// <summary>
        /// مهارت‌ها
        /// </summary>
        //[Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.Skills))]
        //[Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        //public List<string> Skills { get; set; }

        /// <summary>
        /// گواهینامه‌ها و مدارک حرفه‌ای
        /// </summary>
        //[Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.Certifications))]
        //[Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        //public List<string> Certifications { get; set; }

        /// <summary>
        /// ارزیابی عملکرد
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.PerformanceReview))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public string PerformanceReview { get; set; }

        /// <summary>
        /// پروژه‌های اخیر
        /// </summary>
        //[Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.RecentProjects))]
        //[Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        //public List<string> RecentProjects { get; set; }


        /// <summary>
        ///  کلمه عبور
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.Password))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public string Password { get; set; }


        /// <summary>
        /// تکرار کلمه عبور
        /// </summary>
        [Display(ResourceType = typeof(Language_Fa), Name = nameof(Language_Fa.RePassword))]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        [Compare(nameof(Password), ErrorMessage = "تکرار پسورد با خود پسورد متابقت ندارد .")]
        public string RePassword { get; set; }

        public bool IsRemove { get; set; }

    }
}
