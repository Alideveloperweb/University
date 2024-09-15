using Microsoft.AspNetCore.Mvc.Rendering;
using University_Common.Domain;
using University_Common.DTO;


namespace University_Domain.RecentProjectsEntities.Interface
{
    public interface IRecentProjects:IRepositoryBase<int, RecentProjects>
    {
      Task<List<SelectListDto>> GetSelectListRecentProjectsDtos();
        List<SelectListItem> ToRecentProjectsSelectListItems(IEnumerable<RecentProjects> recentProjects);
    }
}
