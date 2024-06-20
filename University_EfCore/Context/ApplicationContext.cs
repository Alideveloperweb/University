

using Microsoft.EntityFrameworkCore;

namespace University_EfCore.Context
{
    public class ApplicationContext : DbContext
    {
        #region Constracture
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        #endregion

        #region Entity



        #endregion

        #region OnModelCreating

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

        #endregion

    }
}
