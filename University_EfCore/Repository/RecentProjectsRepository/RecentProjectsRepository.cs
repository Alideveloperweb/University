using Microsoft.EntityFrameworkCore;
using University_Common.Application;
using University_Domain.DTO;
using University_Domain.RecentProjectsEntities;
using University_Domain.RecentProjectsEntities.Interface;
using University_EfCore.Context;

namespace University_EfCore.Repository.RecentProjectsRepository
{
    public class RecentProjectsRepository : RepositoryBase<int, RecentProjects>, IRecentProjects
    {
        #region Constractor

        public DbContext dbSet;
        public DbSet<RecentProjects>db;

        public RecentProjectsRepository(DbContext dbSet):base(dbSet)
        {
            this.dbSet = dbSet;
            db=dbSet.Set<RecentProjects>();
        }

        public List<SelectListRecentProjectsDto> GetSelectListRecentProjectsDtos()
        {
            return db.Select(rp => new SelectListRecentProjectsDto
            {
                Id = rp.Id, 
                Title=rp.Name
            }).ToList();
        }

        #endregion
    }
}
