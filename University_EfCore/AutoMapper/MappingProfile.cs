using AutoMapper;
using System.Web.Mvc;
using University_Domain.DTO;


namespace University_EfCore.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SelectListDepartmentDto, SelectListItem>()
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id.ToString()))
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Name));

            CreateMap<SelectListCertificationsDto, SelectListItem>()
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id.ToString()))
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Name));

            CreateMap<SelectListJobsDto, SelectListItem>()
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id.ToString()))
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Title));

            CreateMap<SelectListRecentProjectsDto, SelectListItem>()
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id.ToString()))
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Title));

            CreateMap<SelectListSkillsDto, SelectListItem>()
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id.ToString()))
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Title));
        }
    }
}









