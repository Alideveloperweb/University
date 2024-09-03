using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using University_Common.Application;
using University_Domain.DepartmentsEntities;
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

        #endregion

        public async Task<List<SelectListJobsDto>> SelectListJobsDtos()
        {
            return await db.Select(j => new SelectListJobsDto
            {
                Id = j.Id,
                Title = j.Title,
            }).ToListAsync();
        }


        public List<SelectListItem> ToJobSelectListItems(IEnumerable<Job> job)
        {
            if (job == null || !job.Any())
            {
                return new List<SelectListItem>();
            }

            return job.Select(job => new SelectListItem
            {
                Value = job.Id.ToString(),
                Text = job.Title
            }).ToList();
        }
    }
}
