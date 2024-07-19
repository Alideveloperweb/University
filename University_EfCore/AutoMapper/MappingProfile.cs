using AutoMapper;
using System.Web.Mvc;
using University_Domain.DepartmentsEntities;
using University_EfCore.DTOs.Department;


namespace University_EfCore.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DepartmentDTO, SelectListItem>()
                           .ConvertUsing(d => new SelectListItem
                           {
                               Value = d.Id.ToString(),
                               Text = d.Name
                           });

            CreateMap<Department, DepartmentDTO>();
            CreateMap<DepartmentDTO, Department>();
        }
    }
}
