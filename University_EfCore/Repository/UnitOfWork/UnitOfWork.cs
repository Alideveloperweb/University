using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using University_Common.Domain;
using University_Domain.PersonEntities.Interface;
using University_EfCore.Context;

namespace University_EfCore.Repository
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationContext _dbContext;
        private IDbContextTransaction _transaction;
        private Dictionary<Type, object> _repositories;

        public Lazy<IPersonRepository> Person { get; }

        public UnitOfWork(ApplicationContext dbContext, Lazy<IPersonRepository> personRepository)
        {
            _dbContext = dbContext;
            _repositories = new Dictionary<Type, object>();
            Person = personRepository;
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public int Save()
        {
          return _dbContext.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public void CommitTransaction()
        {
            try
            {
                _dbContext.SaveChanges();
                _transaction?.Commit();

            }
            catch (Exception)
            {

               RollbackTransaction();
                throw;
            }
        }

        public void RollbackTransaction()
        {
            _transaction?.Rollback();
        }

        public bool ExistTransaction()
        {
            return _transaction != null;
        }

        public DbSet<TEntity> Entity<TEntity>() where TEntity : class
        {
          return _dbContext.Set<TEntity>();
        }

        public void ChangeState<TEntity>(TEntity entity, EntityState state) where TEntity : class
        {
            _dbContext.Entry(entity).State = state;
        }

        public UnitOfWork TransactionBeginTransaction()
        {
            _transaction = _dbContext.Database.BeginTransaction();
            return this;
        }
    }
}
