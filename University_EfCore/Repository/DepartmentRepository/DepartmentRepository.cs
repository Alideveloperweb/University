
using Microsoft.EntityFrameworkCore;
using University_Common.Application;
using University_Domain.DepartmentsEntities;
using University_Domain.DepartmentsEntities.Interface;
using University_EfCore.Context;

namespace University_EfCore.Repository.DepartmentRepository
{
    public class DepartmentRepository:RepositoryBase<int,Department> ,IDepartmentRepository
    {
        #region Constractor

        private readonly ApplicationContext Context;
        public DepartmentRepository(ApplicationContext _Context):base(_Context)
        {
            this._Context = _Context;
        }

        #endregion


    }
}
