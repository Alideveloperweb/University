using Microsoft.EntityFrameworkCore;
using University_Domain.DepartmentsEntities;
using University_Domain.EmployeeEntities;
using University_Domain.JobEntities;
using University_EfCore.Mapping.DepartmentsMapper;
using University_EfCore.Mapping.EmployeeMapper;
using University_EfCore.Mapping.JobMapper;

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

        #endregion

        #region OnModelCreating

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeMap());
            modelBuilder.ApplyConfiguration(new DepartmentMap());
            modelBuilder.ApplyConfiguration(new JobMap());
            base.OnModelCreating(modelBuilder);
        }

        #endregion

    }
}
