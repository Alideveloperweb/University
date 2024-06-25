
namespace University_Common.Domain
{
    public class PersonalInformation : EntityBase<int>
    {
        #region Properties


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
        public string Address { get; set; }

        /// <summary>
        /// آخرین مدرک تحصیلی
        /// </summary>
        public string LastEducationalCertificate { get; set; }

        /// <summary>
        /// معدل آخرین مدرک تحصیلی
        /// </summary>
        public double GPAOfThelastDegree { get; set; }

        /// <summary>
        /// جنسیت 
        /// </summary>
        public bool Gender { get; set; }

        /// <summary>
        /// وضعیت تاهل 
        /// </summary>
        public bool MaritalStatus { get; set; }


        /// <summary>
        /// تاریخ تولد 
        /// </summary>
        public DateTime DateOfBirth { get; set; }


        /// <summary>
        /// شماره ضروری
        /// </summary>
        public string EmergencyContactNumber { get; set; }


        /// <summary>
        /// شماره ملی همسر در صورت متاهل بودن
        /// </summary>
        public string SpouseNationalID { get; set; }


        /// <summary>
        /// گروه خونی
        /// </summary>
        public string BloodType { get; set; }


        /// <summary>
        ///سابقه بیماری مهم
        /// </summary>
        public string MedicalHistory { get; set; }

        #endregion

    }
}
