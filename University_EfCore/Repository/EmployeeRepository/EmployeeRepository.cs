using University_Common.Application;
using University_Domain.EmployeeEntities;
using University_Domain.EmployeeEntities.Interface;
using University_EfCore.Context;

namespace University_EfCore.Repository.EmployeeRepository
{
    public class EmployeeRepository : RepositoryBase<int, Employee>, IEmployeeRepository
    {
        #region Constracture

        private readonly ApplicationContext _ApplicationContext;
        public EmployeeRepository(ApplicationContext ApplicationContext) : base(ApplicationContext)
        {
            _ApplicationContext = ApplicationContext;
        }

        #endregion

        #region Constracture

        public List<Employee> GetAllEmployee(bool isRemove)
        {
            return null;
            //return _ApplicationContext.Employee.Where(e => e.IsRemove==isRemove).Select(e=>new GetAllEmployeeItem
            //{
            //        EmployeeNumber = e.EmployeeNumber,
            //        EmploymentStatus = e.EmploymentStatus,
            //        FullName=e.FirstName+ " "+e.LastName,
            //        ImageName=e.ImageName,
            //        JobTitle=e.JobTitle,
            //        LastEducationalCertificate=e.LastEducationalCertificate,
            //        Mobile=e.Mobile,
            //        NationalCode=e.NationalCode
            //}).ToList();
        }

        #endregion

    }
}
