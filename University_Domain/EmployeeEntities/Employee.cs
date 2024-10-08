﻿using University_Common.Domain;
using University_Common.Enum;
using University_Domain.Associations;
using University_Domain.DepartmentsEntities;
using University_Domain.JobEntities;

namespace University_Domain.EmployeeEntities
{
    public class Employee : PersonalInformation
    {

        #region Properties

        #region Job Information

        /// <summary>
        /// شماره کارمندی
        /// </summary>
        public string EmployeeNumber { get; set; }

        /// <summary>
        /// تاریخ شروع به کار
        /// </summary>
        public DateTime HireDate { get; set; }

        /// <summary>
        /// حقوق و دستمزد
        /// </summary>
        public int Salary { get; set; }

        /// <summary>
        /// مهارت‌ها
        /// </summary>
        public List<string> Skills { get; set; }

        /// <summary>
        /// وضعیت شغلی (فعال/غیرفعال)
        /// </summary>
        public bool IsActive { get; set; }

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
        /// ارزیابی عملکرد
        /// </summary>
        public string PerformanceReview { get; set; }

        /// <summary>
        /// آدرس ایمیل
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// نام تصویر
        /// </summary>
        public string ImageName { get; set; }

        /// <summary>
        /// کلمه عبور
        /// </summary>
        public string Password { get; set; }

        #endregion

        #region Create

        public Employee(string Username, string FirstName, string LastName, string NationalCode, string Mobile, string Homephone, string CountryName, string CityName, string Address,
                        string LastEducationalCertificate, float GPAOfThelastDegree, Gender Gender, MaritalStatus MaritalStatus, DateTime DateOfBirth, string EmergencyContactNumber,
                        string SpouseNationalID, string BloodType, string MedicalHistory, string EmployeeNumber,
                        DateTime HireDate, int Salary, bool IsActive, int WeeklyWorkingHours, int RemainingLeaveDays, string Supervisor, List<string> Skills,
                        string PerformanceReview, string Password, int DepartmentId, string Email, string ImageName, int JobId)
        {
            this.Username = Username;
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
            this.IsActive = IsActive;
            this.WeeklyWorkingHours = WeeklyWorkingHours;
            this.RemainingLeaveDays = RemainingLeaveDays;
            this.Supervisor = Supervisor;
            this.Skills = Skills;
            this.PerformanceReview = PerformanceReview;
            this.Password = Password;
            this.DepartmentId = DepartmentId;
            this.Email = Email;
            this.ImageName = ImageName;
            this.JobId = JobId;
        }

        #endregion

        #region Edit

        public void Edit(string Username, string FirstName, string LastName, string NationalCode, string Mobile, string Homephone, string CountryName, string CityName, string Address,
                        string LastEducationalCertificate, float GPAOfThelastDegree, Gender Gender, MaritalStatus MaritalStatus, DateTime DateOfBirth, string EmergencyContactNumber,
                        string SpouseNationalID, string BloodType, string MedicalHistory, string EmployeeNumber,
                        DateTime HireDate, int Salary, bool IsActive, int WeeklyWorkingHours, int RemainingLeaveDays, string Supervisor/*, List<string> Skills,*/
                        /*List<string> Certifications*/, string PerformanceReview/*, List<string> RecentProjects*/, string Password, int DepartmentId, string Email, string ImageName, int JobId)
        {
            this.Username = Username;
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
            this.DepartmentId = DepartmentId;
            this.EmployeeNumber = EmployeeNumber;
            this.HireDate = HireDate;
            this.Salary = Salary;
            this.IsActive = IsActive;
            this.WeeklyWorkingHours = WeeklyWorkingHours;
            this.RemainingLeaveDays = RemainingLeaveDays;
            this.Supervisor = Supervisor;
            this.Email = Email;
            // this.Certifications = Certifications;
            this.PerformanceReview = PerformanceReview;
            // this.RecentProjects = RecentProjects;
            this.Password = Password;
            this.DepartmentId = DepartmentId;
            this.ImageName = ImageName;
            this.JobId = JobId;
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

        public ICollection<SkilsEmployee> SkilsEmployees { get; set; }
        public ICollection<CertificationsEmployee> CertificationsEmployees { get; set; }

        public ICollection<RecentProjectsEmployee> RecentProjectsEmployee { get; set; }

        #endregion

        #endregion
    }
}
