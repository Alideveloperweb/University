using University_Common.Domain;
using University_Domain.DTO;

namespace University_Domain.RecentProjectsEntities.Interface
{
    public interface IRecentProjects:IRepositoryBase<int, RecentProjects>
    {
        List<SelectListRecentProjectsDto> GetSelectListRecentProjectsDtos();
    }
}
