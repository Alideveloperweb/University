using University_Common.Domain;
using University_Domain.EmployeeEntities;

namespace University_Domain.DepartmentsEntities
{
    public class Department:EntityBase<int>
    {

        #region Properties

        /// <summary>
        /// نام دپارتمان
        /// </summary>
        public string Name { get; set; }

        //[Required]
        //[StringLength(255)]
        //public string DepartmentName { get; set; }

        //[Required]
        //[StringLength(10)]
        //public string DepartmentCode { get; set; }

        //public int? DepartmentHeadId { get; set; }

        //[DataType(DataType.Date)]
        //public DateTime? EstablishedDate { get; set; }

        //[StringLength(255)]
        //public string DepartmentLocation { get; set; }

        //public int? FacultyCount { get; set; }

        //[EmailAddress]
        //public string ContactEmail { get; set; }

        //[Phone]
        //public string ContactPhone { get; set; }

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
