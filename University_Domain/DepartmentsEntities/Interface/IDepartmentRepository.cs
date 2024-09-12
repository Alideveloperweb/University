using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;
using University_Common.Domain;
using University_Domain.DTO;

namespace University_Domain.DepartmentsEntities.Interface
{
    public interface IDepartmentRepository:IRepositoryBase<int, Department>
    {
       Task<List<SelectListDto>> ToDepartmentDtos();
      //  List<SelectListItem> ToDepartmentSelectListItems(IEnumerable<Department> departments);
    }
}
