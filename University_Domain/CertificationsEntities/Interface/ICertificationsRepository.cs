using Microsoft.AspNetCore.Mvc.Rendering;
using University_Common.Domain;
using University_Domain.DTO;

namespace University_Domain.CertificationsEntities.Interface
{
    public interface ICertificationsRepository:IRepositoryBase<int, Certifications>
    {
       Task<List<SelectListCertificationsDto>> SelectListCertificationsDtos();
        List<SelectListItem> ToCertificationsSelectListItems(IEnumerable<Certifications> certifications);
    }
}
