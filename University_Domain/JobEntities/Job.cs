using University_Common.Domain;
using University_Domain.EmployeeEntities;

namespace University_Domain.JobEntities
{
    public class Job : EntityBase<int>
    {
        public string Title { get; set; }


        #region Relation

        public ICollection<Employee> Employees { get; set; }

        #endregion
    }
}
