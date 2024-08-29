using Microsoft.AspNetCore.Mvc.Rendering;
using University_Common.Domain;

namespace University_Web.Extensions
{
    public static class ExtensionMethods
    {
       
            public static List<string> ToSkillList(this List<SelectListItem>? selectListItems)
            {
                return selectListItems?.Select(item => item.Value).ToList() ?? new List<string>();
            }
        
    }
}
