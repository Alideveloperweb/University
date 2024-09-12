using Microsoft.AspNetCore.Mvc.Rendering;
using University_Domain.DTO;

namespace University_Web.Extensions
{
    public static class SelectListItemHelper
    {
        public static async Task<List<SelectListItem>> ToSelectListItems(this Task<List<SelectListDto>> departmentsTask)
        {
            // ابتدا Task را await کنید تا لیست SelectListDto دریافت شود
            var departments = await departmentsTask;

            // سپس از Select برای تبدیل هر آیتم استفاده کنید
            return departments.Select(dto => new SelectListItem
            {
                Value = dto.Id.ToString(),
                Text = dto.Name
            }).ToList();
        }

        public static void AddDefaultItem(this List<SelectListItem> list, string text = "انتخاب کنید", string value = "")
        {
            // اگر لیست نال بود، ایجاد یک لیست جدید
            if (list == null)
            {
                list = new List<SelectListItem>();
            }

            // بررسی اینکه آیا گزینه پیش‌فرض از قبل وجود دارد یا خیر
            // اگر وجود ندارد، اضافه کردن آن به ابتدای لیست
            if (!list.Any(item => item.Value == value))
            {
                list.Insert(0, new SelectListItem
                {
                    Text = text,
                    Value = value
                });
            }
        }
    }
}
