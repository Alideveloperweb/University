
using University_Common.Domain;
using University_Domain.Associations;
using University_Domain.DTO;

namespace University_Domain.CertificationsEntities.Interface
{
    public interface ICertificationsRepository:IRepositoryBase<int, Certifications>
    {
        List<SelectListCertificationsDto> SelectListDepartmentDtos();
    }
}
