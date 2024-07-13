
using University_Common.Application;
using University_Domain.CertificationsEntities;
using University_Domain.CertificationsEntities.Interface;
using University_EfCore.Context;

namespace University_EfCore.Repository.CertificationsRepository
{
    public class CertificationsRepository:RepositoryBase<int, Certifications>, ICertificationsRepository
    {
        #region Constractor

        private ApplicationContext _Context;
        public CertificationsRepository(ApplicationContext context):base(context) 
        {
                this._Context = context;
        }

        #endregion
    }
}
