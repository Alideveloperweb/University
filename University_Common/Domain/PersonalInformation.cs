
using University_Common.Enum;

namespace University_Common.Domain
{
    public class PersonalInformation : EntityBase<int>
    {
        #region Properties

        #region Identity Information

        /// <summary>
        /// نام کاربری
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// نام 
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// نام خانوادگی
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// کدملی 
        /// </summary>
        public string NationalCode { get; set; }

        /// <summary>
        /// جنسیت 
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// وضعیت تاهل 
        /// </summary>
        public MaritalStatus MaritalStatus { get; set; }

        /// <summary>
        /// تاریخ تولد 
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// شماره ملی همسر در صورت متاهل بودن
        /// </summary>
        public string SpouseNationalID { get; set; }

        #endregion

        #region Contacts

        /// <summary>
        /// تلفن همراه 
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// تلفن خانه  
        /// </summary>
        public string Homephone { get; set; }

        /// <summary>
        /// ایمیل  
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// شماره ضروری
        /// </summary>
        public string EmergencyContactNumber { get; set; }

        /// <summary>
        /// نام کشور  
        /// </summary>
        public string CountryName { get; set; }

        /// <summary>
        /// نام شهر 
        /// </summary>
        public string CityName { get; set; }

        /// <summary>
        /// آدرس
        /// </summary>
        public string? Address { get; set; }

        #endregion


        #region Educational Information

        /// <summary>
        /// آخرین مدرک تحصیلی
        /// </summary>
        public string LastEducationalCertificate { get; set; }

        /// <summary>
        /// معدل آخرین مدرک تحصیلی
        /// </summary>
        public float GPAOfThelastDegree { get; set; }

        #endregion

        #region Medical Information

        /// <summary>
        /// گروه خونی
        /// </summary>
        public string BloodType { get; set; }


        /// <summary>
        ///سابقه بیماری مهم
        /// </summary>
        public string MedicalHistory { get; set; }

        #endregion

        #region Other Information

        /// <summary>
        ///  عکس
        /// </summary>
        public string ImageName { get; set; }

        #endregion

        #endregion

    }
}