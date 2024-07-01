using University_Common.Domain;
using University_Domain.DepartmentsEntities;
using University_Domain.JobEntities;

namespace University_Domain.EmployeeEntities
{
    public class Employee : PersonalInformation
    {

        #region Properties

        /// <summary>
        /// شماره کارمندی
        /// </summary>
        public string EmployeeNumber { get; set; }

        ///// <summary>
        ///// سمت شغلی
        ///// </summary>
        //public string JobTitle { get; set; }

        ///// <summary>
        ///// دپارتمان
        ///// </summary>
        //public string Department { get; set; }

        /// <summary>
        /// تاریخ شروع به کار
        /// </summary>
        public DateTime HireDate { get; set; }

        /// <summary>
        /// حقوق و دستمزد
        /// </summary>
        public decimal Salary { get; set; }

        /// <summary>
        /// وضعیت شغلی (فعال/غیرفعال)
        /// </summary>
        public bool EmploymentStatus { get; set; }

        /// <summary>
        /// ساعات کاری هفتگی
        /// </summary>
        public int WeeklyWorkingHours { get; set; }

        /// <summary>
        /// مرخصی‌های باقیمانده
        /// </summary>
        public int RemainingLeaveDays { get; set; }

        /// <summary>
        /// مسئول مستقیم
        /// </summary>
        public string Supervisor { get; set; }

        /// <summary>
        /// مهارت‌ها
        /// </summary>
        public List<string> Skills { get; set; }

        /// <summary>
        /// گواهینامه‌ها و مدارک حرفه‌ای    
        /// </summary>
        public List<string> Certifications { get; set; }

        /// <summary>
        /// ارزیابی عملکرد
        /// </summary>
        public string PerformanceReview { get; set; }

        /// <summary>
        /// پروژه‌های اخیر
        /// </summary>
        public List<string> RecentProjects { get; set; }

        /// <summary>
        ///    کلمه عبور
        /// </summary>
        public string Password { get; set; }

        #endregion

        #region Create

        public Employee(string FirstName, string LastName, string NationalCode, string Mobile, string Homephone, string CountryName, string CityName, string Address,
                        string LastEducationalCertificate, double GPAOfThelastDegree, bool Gender, bool MaritalStatus, DateTime DateOfBirth, string EmergencyContactNumber,
                        string SpouseNationalID, string BloodType, string MedicalHistory, string EmployeeNumber,
                        DateTime HireDate, decimal Salary, bool EmploymentStatus, int WeeklyWorkingHours, int RemainingLeaveDays, string Supervisor, List<string> Skills,
                        List<string> Certifications, string PerformanceReview, List<string> RecentProjects, string Password)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.NationalCode = NationalCode;
            this.Mobile = Mobile;
            this.Homephone = Homephone;
            this.CountryName = CountryName;
            this.CityName = CityName;
            this.Address = Address;
            this.LastEducationalCertificate = LastEducationalCertificate;
            this.GPAOfThelastDegree = GPAOfThelastDegree;
            this.Gender = Gender;
            this.MaritalStatus = MaritalStatus;
            this.DateOfBirth = DateOfBirth;
            this.EmergencyContactNumber = EmergencyContactNumber;
            this.SpouseNationalID = SpouseNationalID;
            this.BloodType = BloodType;
            this.MedicalHistory = MedicalHistory;
            this.EmployeeNumber = EmployeeNumber;
            this.HireDate = HireDate;
            this.Salary = Salary;
            this.EmploymentStatus = EmploymentStatus;
            this.WeeklyWorkingHours = WeeklyWorkingHours;
            this.RemainingLeaveDays = RemainingLeaveDays;
            this.Supervisor = Supervisor;
            this.Skills = Skills;
            this.Certifications = Certifications;
            this.PerformanceReview = PerformanceReview;
            this.RecentProjects = RecentProjects;
            this.Password = Password;

        }

        #endregion

        #region Edit

        public void Edit()
        {

        }

        #endregion

        #region Remove

        public void Remove()
        {
            this.IsRemove = true;
        }

        #endregion

        #region Restore

        public void Restore()
        {
            this.IsRemove = false;
        }

        #endregion

        #region Relation

        public int JobId { get; set; }
        public Job Job { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        #endregion

    }
}
