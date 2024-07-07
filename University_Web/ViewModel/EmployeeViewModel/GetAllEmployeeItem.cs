
using University_Domain.EmployeeEntities;

namespace University_Web.ViewModel.EmployeeViewModel
{
    public class GetAllEmployeeItem
    {
        public bool IsRemove { get; set; }= false;

        public IQueryable<Employee>? Employees { get; set; }
    }
}
