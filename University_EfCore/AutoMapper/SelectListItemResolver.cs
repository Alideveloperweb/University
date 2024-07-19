using AutoMapper;
using System.Web.Mvc;
using University_EfCore.DTOs.Department;

namespace University_EfCore.AutoMapper
{
    public class SelectListItemResolver : IValueResolver<DepartmentDTO, SelectListItem, SelectListItem>
    {

        public SelectListItem Resolve(DepartmentDTO source, SelectListItem destination, SelectListItem destMember, ResolutionContext context)
        {
            return new SelectListItem
            {
                Value = source.Id.ToString(),
                Text = source.Name
            };
        }
    }
}
