using Microsoft.EntityFrameworkCore;
using University_Domain.CertificationsEntities.Interface;
using University_Domain.DepartmentsEntities.Interface;
using University_Domain.EmployeeEntities.Interface;
using University_Domain.JobEntities;
using University_Domain.RecentProjectsEntities.Interface;
using University_Domain.SkillsEntities.Interface;

namespace University_Common.Domain
{
    public interface IUnitOfWork: IDisposable
    {
        Lazy<IEmployeeRepository> Employee { get; }
        Lazy<IDepartmentRepository> Department { get; }
        Lazy<IJobRepository> Job { get; }
        Lazy<ISkilsRepository> Skills { get; }
        Lazy<IRecentProjects> RecentProjects { get; }
        Lazy<ICertificationsRepository> Certifications{ get; }
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
