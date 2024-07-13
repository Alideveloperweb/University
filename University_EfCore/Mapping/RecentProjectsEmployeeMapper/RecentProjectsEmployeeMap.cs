
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University_Domain.Associations;

namespace University_EfCore.Mapping.RecentProjectsEmployeeMapper
{
    public class RecentProjectsEmployeeMap : IEntityTypeConfiguration<RecentProjectsEmployee>
    {
        public void Configure(EntityTypeBuilder<RecentProjectsEmployee> builder)
        {
            #region Properties

            builder.HasKey(re => new { re.EmployeeId, re.RecentProjectsId });


            #endregion


            #region Relation

            builder.HasOne(re => re.RecentProjects)
            .WithMany(e => e.RecentProjectsEmployee)
            .HasForeignKey(es => es.RecentProjectsId).OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(es => es.Employee)
            .WithMany(s => s.RecentProjectsEmployee)
            .HasForeignKey(es => es.EmployeeId).OnDelete(DeleteBehavior.Restrict);



            #endregion
        }
    }
}
