using Microsoft.EntityFrameworkCore;
using University_Domain.PersonEntities.Interface;
using University_EfCore.Repository;

namespace University_Common.Domain
{
    public interface IUnitOfWork: IDisposable
    {
        Lazy<IPersonRepository> Person { get; }

        int Save();
        Task<int> SaveAsync();

        UnitOfWork TransactionBeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
        bool ExistTransaction();

        DbSet<TEntity> Entity<TEntity>() where TEntity : class;
        void ChangeState<TEntity>(TEntity entity, EntityState state) where TEntity : class;

    }
}
