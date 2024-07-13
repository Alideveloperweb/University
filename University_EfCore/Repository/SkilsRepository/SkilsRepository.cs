using University_Common.Application;
using University_Domain.SkillsEntities;
using University_Domain.SkillsEntities.Interface;
using University_EfCore.Context;

namespace University_EfCore.Repository.SkilsRepository
{
    public class SkilsRepository : RepositoryBase<int, Skills>, ISkilsRepository
    {
        #region Constractor

        private readonly ApplicationContext _Context;
        public SkilsRepository(ApplicationContext _Context) : base(_Context)
        {
            this._Context = _Context;
        }

        #endregion

        #region 

        public List<Skills> GetSkillsByEmployeeId(int employeeId)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
