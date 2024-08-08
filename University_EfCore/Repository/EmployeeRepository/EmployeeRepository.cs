using Microsoft.EntityFrameworkCore;
using University_Common.Application;
using University_Domain.EmployeeEntities;
using University_Domain.EmployeeEntities.Interface;
using University_EfCore.Context;

namespace University_EfCore.Repository.EmployeeRepository
{
    public class EmployeeRepository : RepositoryBase<int, Employee>, IEmployeeRepository
    {
        #region Constracture

        public DbContext dbSet;
        public DbSet<Employee> db;

        public EmployeeRepository(DbContext dbSet) : base(dbSet)
        {
            this.dbSet = dbSet;
            this.db = dbSet.Set<Employee>();
        }


        #endregion

        #region 





        #endregion

    }
}




