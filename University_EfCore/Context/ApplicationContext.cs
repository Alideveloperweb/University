

using Microsoft.EntityFrameworkCore;
using University_Domain.PersonEntities;
using University_EfCore.Mapping.PersonMapper;

namespace University_EfCore.Context
{
    public class ApplicationContext : DbContext
    {
        #region Constracture
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        #endregion

        #region Entity

        public DbSet<Person> Person { get; set; }

        #endregion

        #region OnModelCreating

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonMap());
            base.OnModelCreating(modelBuilder);
        }

        #endregion

    }
}
