using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;
using University_Common.Domain;
using University_Domain.PersonEntities.Interface;
using University_EfCore.Context;
using University_EfCore.Repository.PersonRepository;
using University_EfCore.Repository.UnitOfWorks;


namespace University_EfCore.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationContext _context;
        private readonly ILogger _logger;
        private UnitOfWorkTransaction? _transaction = null;

        public Lazy<IPersonRepository> Person { get; private set; }

        public UnitOfWork(ApplicationContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("logs");

            Person = new Lazy<IPersonRepository>(() => new PersonRepositorys(context));
        }



        public void CommitTransaction()
        {
            if (null == _transaction)
                throw new Exception("Transaction Not Began");
            _transaction.Commit();
            _transaction = null;
        }

        public void RollbackTransaction()
        {
            if (null == _transaction)
                throw new Exception("Transaction Not Began");
            _transaction.Rollback();
            _transaction = null;
        }

        public bool ExistTransaction()
        {
            return _transaction != null;
        }

        public DbSet<TEntity> Entity<TEntity>() where TEntity : class
        {
            return _context.Set<TEntity>();
        }

        public void ChangeState<TEntity>(TEntity entity, EntityState state) where TEntity : class
        {
            _context.Entry(entity).State = state;
        }

        //public IDbContextTransaction BeginTransaction()
        //{
        //    return _context.Database.BeginTransaction();
        //}

        public void Dispose()
        {
            _context.Dispose();
            _transaction?.Dispose();
        }

       public UnitOfWorkTransaction BeginTransaction()
       {
           if (null == _transaction)
           {
               this._transaction = new UnitOfWorkTransaction(_context);
           }

           return _transaction;
       }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }

}
