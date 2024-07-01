
using University_Domain.EmployeeEntities;

namespace University_Domain.DepartmentsEntities
{
    public class Department
    {


        public ICollection<Employee> Employees { get; set; }
    }
}
