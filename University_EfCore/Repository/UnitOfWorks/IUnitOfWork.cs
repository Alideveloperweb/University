using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using University_Domain.PersonEntities.Interface;
using University_EfCore.Context;

namespace University_Common.Domain
{
    public interface IUnitOfWork: IDisposable
    {
        Lazy<IPersonRepository> Person { get; }
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
