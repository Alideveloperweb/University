using University_Domain.DepartmentsEntities;

namespace University_Web.ViewModel.DepartmentViewModel
{
    public class GetAllDepartmentItem
    {
        public bool IsRemove { get; set; }

        public IQueryable<Department>? Department { get; set; }
    }
}
