using Microsoft.EntityFrameworkCore;
using University_Domain.EmployeeEntities;
using University_EfCore.Mapping.EmployeeMapper;

namespace University_EfCore.Context
{
    public class ApplicationContext : DbContext
    {
        #region Constracture
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        #endregion

        #region Entity

        public DbSet<Employee> Employee { get; set; }

        #endregion

        #region OnModelCreating

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeMap());
            base.OnModelCreating(modelBuilder);
        }

        #endregion

    }
}
