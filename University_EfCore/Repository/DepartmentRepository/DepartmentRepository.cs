using University_Common.Application;
using University_Domain.DepartmentsEntities;
using University_Domain.DepartmentsEntities.Interface;
using University_Domain.DTO;
using University_EfCore.Context;

namespace University_EfCore.Repository.DepartmentRepository
{
    public class DepartmentRepository:RepositoryBase<int,Department> ,IDepartmentRepository
    {
        #region Constractor

        private readonly ApplicationContext _ApplicationContext;
        public DepartmentRepository(ApplicationContext ApplicationContext) : base(ApplicationContext)
        {
            _ApplicationContext = ApplicationContext;
        }

        #endregion

        public List<SelectListDepartmentDto> SelectListDepartmentDtos()
        {
            return _ApplicationContext.Departments
        }
    }
}
