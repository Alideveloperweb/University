
using University_Domain.EmployeeEntities;
using University_Domain.RecentProjectsEntities;

namespace University_Domain.Associations
{
    public class RecentProjectsEmployee
    {
        public int RecentProjectsEmployeeId { get; set; }
        
        public int RecentProjectsId { get; set; }
       
        public int EmployeeId { get; set; }
        
        public RecentProjects RecentProjects { get; set; }
        
        public Employee Employee { get; set; }

    }
}
