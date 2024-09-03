using Microsoft.AspNetCore.Mvc.Rendering;
using University_Domain.DTO;

namespace University_Web.Extensions
{
    public static class SelectListItemHelper
    {
        public static List<SelectListItem> ToSelectListItems(this List<SelectListDepartmentDto> departments)
        {
            return departments.Select(dto => new SelectListItem
            {
                Value = dto.Id.ToString(), 
                Text = dto.Name
            }).ToList();
        }
    }
}
