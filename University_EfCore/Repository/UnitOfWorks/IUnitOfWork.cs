using Microsoft.EntityFrameworkCore;
using University_Domain.DepartmentsEntities.Interface;
using University_Domain.EmployeeEntities.Interface;
using University_Domain.JobEntities;


namespace University_Common.Domain
{
    public interface IUnitOfWork: IDisposable
    {
        Lazy<IEmployeeRepository> Employee { get; }
        Lazy<IDepartmentRepository> Department { get; }
        Lazy<IJobRepository> Job { get; }
      //  ApplicationContext DbContext { get; }

        int Save();
        Task<int> SaveAsync();

       // IDbContextTransaction BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
        bool ExistTransaction();

        DbSet<TEntity> Entity<TEntity>() where TEntity : class;
        void ChangeState<TEntity>(TEntity entity, EntityState state) where TEntity : class;

    }
}
