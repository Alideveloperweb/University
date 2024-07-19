using AutoMapper;
using University_Domain.DepartmentsEntities;
using University_EfCore.DTOs.Department;


namespace University_EfCore.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Department, DepartmentDTO>();
            CreateMap<DepartmentDTO, Department>();
        }
    }
}
