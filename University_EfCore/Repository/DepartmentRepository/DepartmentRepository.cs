using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using University_Common.Application;
using University_Domain.DepartmentsEntities;
using University_Domain.DepartmentsEntities.Interface;
using University_Domain.DTO;


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

        public List<SelectListDepartmentDto> SelectListDepartmentDtos()
        {
            return db.Select(d => new SelectListDepartmentDto 
            {
                Id = d.Id,
                Name = d.Name,
            }).ToList();
        }

        public List<SelectListItem> ToDepartmentSelectListItems(IEnumerable<SelectListDepartmentDto> departments)
        {
            if (departments == null || !departments.Any())
            {
                return new List<SelectListItem>();
            }

            return departments.Select(department => new SelectListItem
            {
                Value = department.Id.ToString(), 
                Text = department.Name
            }).ToList();
        }
    }
}
