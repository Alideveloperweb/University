
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University_Domain.RecentProjectsEntities;

namespace University_EfCore.Mapping.RecentProjectsMapper
{
    public class RecentProjectsMap : IEntityTypeConfiguration<RecentProjects>
    {
        public void Configure(EntityTypeBuilder<RecentProjects> builder)
        {
            #region Properties

            builder.HasKey(x => x.Id);
            builder.Property(j => j.Name);

            #endregion

            #region Relation

            #endregion

        }
    }
}
