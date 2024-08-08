using Microsoft.EntityFrameworkCore;
using University_Common.Application;
using University_Domain.DTO;
using University_Domain.JobEntities;

namespace University_EfCore.Repository.JobRepository
{
    public class JobRepository : RepositoryBase<int, Job>, IJobRepository
    {
        #region Constractor

        public DbContext dbSet;
        public DbSet<Job> db;

        public JobRepository(DbContext dbSet) : base(dbSet)
        {
            this.dbSet = dbSet;
            this.db = dbSet.Set<Job>();
        }

        public List<SelectListJobsDto> SelectListDepartmentDtos()
        {
            return db.Select(j => new SelectListJobsDto
            {
                Id = j.Id,
                Title= j.Title,
            }).ToList();
        }
        #endregion
    }
}
