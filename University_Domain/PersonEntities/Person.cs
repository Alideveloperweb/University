

using University_Common.Domain;

namespace University_Domain.PersonEntities
{
    public class Person : EntityBase<int>
    {
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
        public string GPAOfThelastDegree { get; set; }

        /// <summary>
        /// جنسیت 
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// وضعیت تاهل 
        /// </summary>
        public string MaritalStatus { get; set; }


        /// <summary>
        /// تاریخ تولد 
        /// </summary>
        public string DateOfBirth { get; set; }


        /// <summary>
        /// شماره ضروری
        /// </summary>
        public string EmergencyContactNumber { get; set; }


        /// <summary>
        /// کد پرسونلی
        /// </summary>
        public string PostalCode { get; set; }


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
    }
}















