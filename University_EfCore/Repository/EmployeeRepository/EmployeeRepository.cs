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

    }
}
