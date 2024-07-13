using University_Common.Domain;

namespace University_Domain.SkillsEntities.Interface
{
    public interface ISkilsRepository : IRepositoryBase<int,Skills>
    {
        List<Skills> GetSkillsByEmployeeId(int employeeId);
    }
}
