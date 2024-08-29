using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using University_Common.Domain;
using University_Domain.DTO;

namespace University_Domain.DepartmentsEntities.Interface
{
    public interface IDepartmentRepository:IRepositoryBase<int, Department>
    {
        List<SelectListDepartmentDto> SelectListDepartmentDtos();
        List<SelectListItem> ToDepartmentSelectListItems(IEnumerable<SelectListDepartmentDto> departments);
    }
}
