using University_Common.Domain;
using University_Domain.DTO;

namespace University_Domain.JobEntities
{
    public interface IJobRepository : IRepositoryBase<int, Job>
    {
        List<SelectListJobsDto> SelectListDepartmentDtos();
    }
}
