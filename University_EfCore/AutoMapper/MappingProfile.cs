


using AutoMapper;
using System.Web.Mvc;
using University_Domain.DepartmentsEntities;
using University_Domain.JobEntities;

using University_Domain.DTO;
using University_Domain.SkillsEntities;
using University_Domain.RecentProjectsEntities;
using University_Domain.CertificationsEntities;


namespace University_EfCore.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // نگاشت از Department به SelectListDepartmentDto
            CreateMap<Department, SelectListDepartmentDto>();

            // نگاشت از SelectListDepartmentDto به SelectListItem
            CreateMap<Department, SelectListDepartmentDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

            CreateMap<Certifications, SelectListCertificationsDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

            CreateMap<Job, SelectListJobsDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title));


            CreateMap<RecentProjects, SelectListRecentProjectsDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Name));

            CreateMap<Skills, SelectListSkillsDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Name));
        }
    }
}









