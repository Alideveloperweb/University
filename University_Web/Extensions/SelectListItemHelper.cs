using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace University_Web.Extensions
{
    public static class SelectListItemHelper
    {
        public static List<SelectListItem> ToSelectListItems<T>(this IEnumerable<T> items, Func<T, string> getValue, Func<T, string> getText)
        {
            if (items == null)
            {
                return new List<SelectListItem>();
            }

            return items.Select(item => new SelectListItem
            {
                Value = getValue(item),
                Text = getText(item)
            }).ToList();
        }
    }
}
