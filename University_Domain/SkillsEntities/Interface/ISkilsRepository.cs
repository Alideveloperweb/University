using Microsoft.AspNetCore.Mvc.Rendering;
using University_Common.Domain;
using University_Domain.DTO;

namespace University_Domain.SkillsEntities.Interface
{
    public interface ISkilsRepository : IRepositoryBase<int,Skills>
    {
        List<SelectListSkillsDto> GetSkillsByEmployeeId(int employeeId);
        List<SelectListItem> ToSkilsSelectListItems(IEnumerable<Skills> skils);
    }
}
