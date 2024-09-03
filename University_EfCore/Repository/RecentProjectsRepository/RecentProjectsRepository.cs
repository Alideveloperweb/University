using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using University_Common.Application;
using University_Domain.DTO;
using University_Domain.RecentProjectsEntities;
using University_Domain.RecentProjectsEntities.Interface;

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

        public async Task<List<SelectListRecentProjectsDto>> GetSelectListRecentProjectsDtos()
        {
            return await db.Select(rp => new SelectListRecentProjectsDto
            {
                Id = rp.Id, 
                Title=rp.Name
            }).ToListAsync();
        }

        #endregion

        public List<SelectListItem> ToRecentProjectsSelectListItems(IEnumerable<RecentProjects> recentProjects)
        {
            if (recentProjects == null || !recentProjects.Any())
            {
                return new List<SelectListItem>();
            }

            return recentProjects.Select(recentProjects => new SelectListItem
            {
                Value = recentProjects.Id.ToString(),
                Text = recentProjects.Name
            }).ToList();
        }
    }

}
