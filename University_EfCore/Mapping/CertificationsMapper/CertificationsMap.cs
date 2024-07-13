using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University_Domain.CertificationsEntities;

namespace University_EfCore.Mapping.CertificationsMapper
{
    public class CertificationsMap : IEntityTypeConfiguration<Certifications>
    {
        public void Configure(EntityTypeBuilder<Certifications> builder)
        {
            #region Properties

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).HasMaxLength(20);


            #endregion


            #region Relation


            #endregion
        }
    }
}
