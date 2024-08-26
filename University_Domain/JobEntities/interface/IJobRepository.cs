using Microsoft.AspNetCore.Mvc.Rendering;
using University_Common.Domain;
using University_Domain.DepartmentsEntities;
using University_Domain.DTO;

namespace University_Domain.JobEntities
{
    public interface IJobRepository : IRepositoryBase<int, Job>
    {
        List<SelectListJobsDto> SelectListDepartmentDtos();
        List<SelectListItem> ToJobSelectListItems(IEnumerable<Job> job);
    }
}
