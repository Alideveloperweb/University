using Microsoft.EntityFrameworkCore;
using University_Domain.Associations;
using University_Domain.CertificationsEntities;
using University_Domain.DepartmentsEntities;
using University_Domain.EmployeeEntities;
using University_Domain.JobEntities;
using University_Domain.RecentProjectsEntities;
using University_Domain.SkillsEntities;
using University_EfCore.Mapping.CertificationsMapper;
using University_EfCore.Mapping.DepartmentsMapper;
using University_EfCore.Mapping.EmployeeMapper;
using University_EfCore.Mapping.JobMapper;
using University_EfCore.Mapping.RecentProjectsMapper;
using University_EfCore.Mapping.SkillsMapper;

namespace University_EfCore.Context
{
    public class ApplicationContext : DbContext
    {
        #region Constracture
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        #endregion

        #region Entity

        public DbSet<Employee> Employee { get; set; }
        
        public DbSet<Department> Departments { get; set; }
        
        public DbSet<Job> Job { get; set; }
        
        public DbSet<Skills> Skills { get; set; }
        
        public DbSet<RecentProjects> RecentProjects  { get; set; }
        
        public DbSet<Certifications>  Certifications  { get; set; }
        
        public DbSet<CertificationsEmployee> CertificationsEmployee { get; set; }
        
        public DbSet<RecentProjectsEmployee> RecentProjectsEmployee { get; set; }
       
        public DbSet<SkilsEmployee> SkilsEmployee { get; set; }

        #endregion

        #region OnModelCreating

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeMap());
            modelBuilder.ApplyConfiguration(new DepartmentMap());
            modelBuilder.ApplyConfiguration(new JobMap());
            modelBuilder.ApplyConfiguration(new SkillsMap());
            modelBuilder.ApplyConfiguration(new RecentProjectsMap());
            modelBuilder.ApplyConfiguration(new CertificationsMap());

            base.OnModelCreating(modelBuilder);
        }

        #endregion

    }
}
