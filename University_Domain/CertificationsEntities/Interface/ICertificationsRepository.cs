using Microsoft.AspNetCore.Mvc.Rendering;
using University_Common.Domain;
using University_Common.DTO;


namespace University_Domain.CertificationsEntities.Interface
{
    public interface ICertificationsRepository:IRepositoryBase<int, Certifications>
    {
       Task<List<SelectListDto>> SelectListCertificationsDtos();
        List<SelectListItem> ToCertificationsSelectListItems(IEnumerable<Certifications> certifications);
    }
}
