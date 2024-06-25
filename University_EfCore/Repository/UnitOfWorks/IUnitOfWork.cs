using Microsoft.EntityFrameworkCore;
using University_Domain.EmployeeEntities.Interface;


namespace University_Common.Domain
{
    public interface IUnitOfWork: IDisposable
    {
        Lazy<IEmployeeRepository> Employee { get; }
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
