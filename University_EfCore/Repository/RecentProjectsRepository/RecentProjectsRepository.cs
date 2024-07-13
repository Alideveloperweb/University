using University_Common.Application;
using University_Domain.RecentProjectsEntities;
using University_Domain.RecentProjectsEntities.Interface;
using University_EfCore.Context;

namespace University_EfCore.Repository.RecentProjectsRepository
{
    public class RecentProjectsRepository:RepositoryBase<int , RecentProjects>, IRecentProjects
    {
        #region Constractor

        private ApplicationContext _Context;
        public RecentProjectsRepository(ApplicationContext _Context):base(_Context)
        {
            this._Context = _Context;
        }

        #endregion
    }
}
