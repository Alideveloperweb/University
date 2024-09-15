using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using University_Common.Application;
using University_Common.DTO;
using University_Domain.CertificationsEntities;
using University_Domain.CertificationsEntities.Interface;


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

        public async Task<List<SelectListDto>> SelectListCertificationsDtos()
        {
            return await db.Select(c => new SelectListDto
            {
               Id= c.Id,
                Name = c.Name,
            }).ToListAsync();
        }

        public List<SelectListItem> ToCertificationsSelectListItems(IEnumerable<Certifications> certifications)
        {
            if (certifications == null || !certifications.Any())
            {
                return new List<SelectListItem>();
            }

            return certifications.Select(certifications => new SelectListItem
            {
                Value = certifications.Id.ToString(),
                Text = certifications.Name
            }).ToList();
        }

    }
}
