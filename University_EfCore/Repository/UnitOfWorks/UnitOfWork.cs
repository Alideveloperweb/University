using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using University_Common.Domain;
using University_Domain.CertificationsEntities.Interface;
using University_Domain.DepartmentsEntities.Interface;
using University_Domain.EmployeeEntities.Interface;
using University_Domain.JobEntities;
using University_Domain.RecentProjectsEntities.Interface;
using University_Domain.SkillsEntities.Interface;
using University_EfCore.Context;
using University_EfCore.Repository.UnitOfWorks;


namespace University_EfCore.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationContext _context;
        private readonly ILogger _logger;
        private UnitOfWorkTransaction? _transaction = null;

        public Lazy<IEmployeeRepository> Employee { get; private set; }

        public Lazy<IDepartmentRepository> Department { get; private set; }

        public Lazy<IJobRepository> Job { get; private set; }

        public Lazy<ISkilsRepository> Skills { get; private set; }

        public Lazy<IRecentProjects> RecentProjects { get;private set; }

        public Lazy<ICertificationsRepository> Certifications { get;private set; }

        public UnitOfWork(ApplicationContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("logs");

            Employee = new Lazy<IEmployeeRepository>(() => new EmployeeRepository.EmployeeRepository(context));
            Department = new Lazy<IDepartmentRepository>(()=>new  DepartmentRepository.DepartmentRepository(context));
            Job = new Lazy<IJobRepository>(() => new JobRepository.JobRepository(context));
            Skills = new Lazy<ISkilsRepository>(() => new SkilsRepository.SkilsRepository(context));
            RecentProjects = new Lazy<IRecentProjects>(() => new RecentProjectsRepository.RecentProjectsRepository(context));
            Certifications = new Lazy<ICertificationsRepository>(() => new CertificationsRepository.CertificationsRepository(context));
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
