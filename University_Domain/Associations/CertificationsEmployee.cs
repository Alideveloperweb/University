
using University_Domain.CertificationsEntities;
using University_Domain.EmployeeEntities;

namespace University_Domain.Associations
{
    public class CertificationsEmployee
    {
        public int CertificationsEmployeeId { get; set; }
        
        public int CertificationsId { get; set; }
        
        public int EmployeeId { get; set; }
        
        public Employee Employee { get; set; }

        public Certifications Certification { get; set; }
    }
}
