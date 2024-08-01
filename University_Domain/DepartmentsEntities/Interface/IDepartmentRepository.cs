using University_Common.Domain;
using University_Domain.DTO;

namespace University_Domain.DepartmentsEntities.Interface
{
    public interface IDepartmentRepository:IRepositoryBase<int, Department>
    {
        List<SelectListDepartmentDto> SelectListDepartmentDtos();
    }
}
