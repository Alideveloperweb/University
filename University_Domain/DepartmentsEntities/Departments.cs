
using System.Collections.Specialized;
using University_Common.Domain;
using University_Domain.EmployeeEntities;
using University_Domain.JobEntities;

namespace University_Domain.DepartmentsEntities
{
    public class Department:EntityBase<int>
    {

        #region Properties

        /// <summary>
        /// نام دپارتمان
        /// </summary>
        public string Name { get; set; }


        #endregion

        #region Create

        public Department(string Name) => this.Name = Name;

        #endregion

        #region Edit

        public void Edit(string Name)
        {
            this.Name = Name;
        }

        #endregion

        #region Remove

        public void Remove()
        {
            this.IsRemove = true;
        }

        #endregion

        #region Restore

        public void Restore()
        {
            this.IsRemove = false;
        }

        #endregion

        #region Relation

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();


        #endregion
    }
}
