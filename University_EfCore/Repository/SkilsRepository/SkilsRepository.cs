using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using University_Common.Application;
using University_Common.DTO;
using University_Domain.SkillsEntities;
using University_Domain.SkillsEntities.Interface;

namespace University_EfCore.Repository.SkilsRepository
{
    public class SkilsRepository : RepositoryBase<int, Skills>, ISkilsRepository
    {
        #region Constractor

        public DbContext dbSet;
        public DbSet<Skills> db;

        public SkilsRepository(DbContext dbSet):base(dbSet)
        {
            this.dbSet = dbSet;
            db=dbSet.Set<Skills>();
        }

        #endregion

        #region 

        public async Task<List<SelectListDto>> SelectListSkillsDtos()
        {
            return await db.Select(j => new SelectListDto
            {
                Id = j.Id,
                Name = j.Name,
            }).ToListAsync();
        }

        public List<SelectListDto> GetSkillsByEmployeeId(int employeeId)
        {
            return db.Select(s => new SelectListDto
            {
                Id = s.Id,
                Name=s.Name,
            }).ToList();  
        }

        public List<SelectListItem> ToSkilsSelectListItems(IEnumerable<Skills> skils)
        {
            if (skils == null || !skils.Any())
            {
                return new List<SelectListItem>();
            }

            return skils.Select(skils => new SelectListItem
            {
                Value = skils.Id.ToString(),
                Text = skils.Name
            }).ToList();
        }
        #endregion
    }
}
