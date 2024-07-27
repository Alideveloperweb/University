using University_Common.Domain;
using University_Domain.DTO;


namespace University_Domain.EmployeeEntities.Interface
{
    public interface IEmployeeRepository: IRepositoryBase<int,Employee>
    {
       List<SelectListDepartmentDto> SelectListDepartmentDtos();
       List<SelectListJobsDto> SelectListJobsDtos();
       List<SelectListSkillsDto> SelectListSkillsDtos();
       List<SelectListRecentProjectsDto> SelectListRecentProjectsDtos();
       List<SelectListCertificationsDto> SelectListCertificationsDtos();
    }
}
