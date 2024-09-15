using Microsoft.AspNetCore.Mvc.Rendering;
using University_Common.DTO;


namespace University_Web.Extensions
{
    public static class SelectListItemHelper
    {
     
            public static async Task<List<SelectListItem>> ToSelectListItems(this Task<List<SelectListDto>> departmentsTask)
            {
                var departments = await departmentsTask;
                return departments.Select(dto => new SelectListItem
                {
                    Value = dto.Id.ToString(),
                    Text = dto.Name
                }).ToList();
            }



        public static async Task<List<SelectListItem>> AddDefaultItem(this Task<List<SelectListItem>> taskList, string text = "انتخاب کنید", string value = "")
        {
            var list = await taskList;

            if (list == null)
            {
                list = new List<SelectListItem>();
            }

            if (!list.Any(item => item.Value == value))
            {
                list.Insert(0, new SelectListItem
                {
                    Text = text,
                    Value = value
                });
            }

            return list;
        }

    }
}
