using Microsoft.AspNetCore.Mvc.Rendering;
using University_Common.Domain;
using University_Domain.DTO;

namespace University_Domain.SkillsEntities.Interface
{
    public interface ISkilsRepository : IRepositoryBase<int,Skills>
    {
        List<SelectListDto> GetSkillsByEmployeeId(int employeeId);
        Task<List<SelectListDto>> SelectListSkillsDtos();
        List<SelectListItem> ToSkilsSelectListItems(IEnumerable<Skills> skils);
    }
}
