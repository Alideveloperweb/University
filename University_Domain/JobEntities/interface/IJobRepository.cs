using Microsoft.AspNetCore.Mvc.Rendering;
using University_Common.Domain;
using University_Common.DTO;


namespace University_Domain.JobEntities
{
    public interface IJobRepository : IRepositoryBase<int, Job>
    {
       Task<List<SelectListDto>> SelectListJobsDtos();
        List<SelectListItem> ToJobSelectListItems(IEnumerable<Job> job);
    }
}
