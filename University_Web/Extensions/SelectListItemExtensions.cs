using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace University_Web.Extensions
{
    public static class SelectListItemExtensions
    {
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