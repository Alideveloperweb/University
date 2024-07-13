using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using University_Domain.JobEntities;

namespace University_EfCore.Mapping.JobMapper
{
    public class JobMap : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            #region Properties

            builder.HasKey(x => x.Id);
            builder.Property(j=>j.Title);

            #endregion

            #region Relashin

            #endregion
            builder.HasMany(j => j.Employees)
                  .WithOne(e => e.Job)
                  .HasForeignKey(e => e.JobId);

        }
    }
}
