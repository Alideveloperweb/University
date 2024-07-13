using University_Domain.EmployeeEntities;
using University_Domain.SkillsEntities;

namespace University_Domain.Associations
{
    public class SkilsEmployee
    {
        public int SkilsEmployeeId { get; set; }

        public int SkillsId { get; set; }
        
        public int EmployeeId { get; set; }
        
        public Skills Skill { get; set; }
        
        public Employee Employee { get; set; }

        
    }
}
