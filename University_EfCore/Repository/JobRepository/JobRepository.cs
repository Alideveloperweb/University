using University_Common.Application;
using University_Domain.JobEntities;
using University_EfCore.Context;

namespace University_EfCore.Repository.JobRepository
{
    public class JobRepository:RepositoryBase<int ,Job>, IJobRepository
    {
        #region Constractor

        private readonly ApplicationContext  _Context;
        public JobRepository(ApplicationContext _Context):base(_Context)
        {
                this._Context = _Context;
        }
        #endregion
    }
}
