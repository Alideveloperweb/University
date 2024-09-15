using Microsoft.EntityFrameworkCore;
using University_Common.Application;
using University_Domain.DepartmentsEntities;
using University_Domain.DepartmentsEntities.Interface;
using University_Common.DTO;


namespace University_EfCore.Repository.DepartmentRepository
{
    public  class DepartmentRepository:RepositoryBase<int,Department> ,IDepartmentRepository
    {
        #region Constractor

        public DbContext dbSet;
        public DbSet<Department> db;

        public DepartmentRepository(DbContext dbSet):base(dbSet)
        {
            this.dbSet = dbSet;
            this.db = dbSet.Set<Department>();
        }

        #endregion

        public async Task<List<SelectListDto>> ToDepartmentDtos()
        {
            return  await db.Select(d => new SelectListDto
            {
                Id = d.Id,
                Name = d.Name,
            }).ToListAsync();
        }

        //public async Task<List<SelectListDto>> ToDepartmentDtos(IEnumerable<SelectListDto> departments)
        //{
        //    if (departments == null || !departments.Any())
        //    {
        //        return new List<SelectListDto>();
        //    }

        //    return departments.Select(department => new SelectListDto
        //    {
        //        Id = department.Id.,
        //        Name = department.Name
        //    }).ToList();
        //}

        //public List<SelectListItem> ToDepartmentSelectListItems(IEnumerable<Department> departments)
        //{
        //    if (departments == null || !departments.Any())
        //    {
        //        return new List<SelectListItem>();
        //    }

        //    return departments.Select(department => new SelectListItem
        //    {
        //        Value = department.Id.ToString(),
        //        Text = department.Name
        //    }).ToList();
        //}
    }
}
