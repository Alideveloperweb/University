using University_Common.Application;
using University_Domain.DTO;
using University_Domain.EmployeeEntities;
using University_Domain.EmployeeEntities.Interface;
using University_EfCore.Context;

namespace University_EfCore.Repository.EmployeeRepository
{
    public class EmployeeRepository : RepositoryBase<int, Employee>, IEmployeeRepository
    {
        #region Constracture

        private readonly ApplicationContext _ApplicationContext;
        public EmployeeRepository(ApplicationContext ApplicationContext) : base(ApplicationContext)
        {
            _ApplicationContext = ApplicationContext;
        }

        #endregion

        #region 

        public List<SelectListDepartmentDto> SelectListDepartmentDtos()
        {
            return _ApplicationContext.Departments.Select(d => new SelectListDepartmentDto
            {
                Id=d.Id,
                Name=d.Name,
            }).ToList();
        }

        public List<SelectListJobsDto> SelectListJobsDtos()
        {
            return _ApplicationContext.Job.Select(d => new SelectListJobsDto
            {
                Id = d.Id,
                Title = d.Title,
            }).ToList();
        }

        public List<SelectListRecentProjectsDto> SelectListRecentProjectsDtos()
        {
            return _ApplicationContext.Job.Select(d => new SelectListRecentProjectsDto
            {
                Id = d.Id,
                Title = d.Title,
            }).ToList();
        }

        public List<SelectListSkillsDto> SelectListSkillsDtos()
        {
            return _ApplicationContext.Job.Select(d => new SelectListSkillsDto
            {
                Id = d.Id,
                Title = d.Title,
            }).ToList();
        }


        public List<SelectListCertificationsDto> SelectListCertificationsDtos()
        {
            return _ApplicationContext.Job.Select(d => new SelectListCertificationsDto
            {
                Id = d.Id,
                Title = d.Title,
            }).ToList();
        }
        #endregion

    }
}




