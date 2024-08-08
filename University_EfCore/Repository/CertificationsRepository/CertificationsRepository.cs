using Microsoft.EntityFrameworkCore;
using University_Common.Application;
using University_Domain.CertificationsEntities;
using University_Domain.CertificationsEntities.Interface;
using University_Domain.DTO;

namespace University_EfCore.Repository.CertificationsRepository
{
    public class CertificationsRepository:RepositoryBase<int, Certifications>, ICertificationsRepository
    {
        #region Constractor

        public DbContext dbSet;
        public DbSet<Certifications> db;

        public CertificationsRepository(DbContext dbSet) : base(dbSet)
        {
            this.dbSet = dbSet;
            this.db = dbSet.Set<Certifications>();
        }

        #endregion

        public List<SelectListCertificationsDto> SelectListDepartmentDtos()
        {
            return db.Select(c => new SelectListCertificationsDto
            {
               Id= c.Id,
                Name = c.Name,
            }).ToList();
        }

    }
}
