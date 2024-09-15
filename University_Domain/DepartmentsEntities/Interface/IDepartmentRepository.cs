using University_Common.Domain;
using University_Common.DTO;


namespace University_Domain.DepartmentsEntities.Interface
{
    public interface IDepartmentRepository:IRepositoryBase<int, Department>
    {
       Task<List<SelectListDto>> ToDepartmentDtos();
      //  List<SelectListItem> ToDepartmentSelectListItems(IEnumerable<Department> departments);
    }
}
