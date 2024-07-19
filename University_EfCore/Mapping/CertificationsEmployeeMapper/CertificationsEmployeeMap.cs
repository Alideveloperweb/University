using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University_Domain.Associations;

namespace University_EfCore.Mapping.CertificationsEmployeeMapper
{
    public class CertificationsEmployeeMap : IEntityTypeConfiguration<CertificationsEmployee>
    {
        public void Configure(EntityTypeBuilder<CertificationsEmployee> builder)
        {
            #region Properties

            builder.HasKey(ce => ce.CertificationsEmployeeId );

            #endregion

            #region Relation

            builder.HasOne(re => re.Certification)
            .WithMany(e => e.CertificationsEmployees)
            .HasForeignKey(es => es.CertificationsId).OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(es => es.Employee)
            .WithMany(s => s.CertificationsEmployees)
            .HasForeignKey(es => es.EmployeeId).OnDelete(DeleteBehavior.Restrict);

            #endregion
        }
    }
}
