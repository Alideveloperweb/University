using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University_Domain.PersonEntities;

namespace University_EfCore.Mapping.PersonMapper
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            #region Properties

            builder.HasKey(p => p.Id);
            builder.Property(p => p.FirstName).HasMaxLength(20);
            builder.Property(p => p.LastName).HasMaxLength(50);
            builder.Property(p => p.NationalCode).HasMaxLength(10);
            builder.Property(p => p.Mobile).HasMaxLength(11);
            builder.Property(p => p.Homephone).HasMaxLength(11);
            builder.Property(p => p.Email).HasMaxLength(300);
            builder.Property(p => p.CountryName).HasMaxLength(60);
            builder.Property(p => p.Address).HasMaxLength(600);
            builder.Property(p => p.LastEducationalCertificate).HasMaxLength(20);
            builder.Property(p => p.GPAOfThelastDegree).HasMaxLength(20);
            builder.Property(p => p.Gender);
            builder.Property(p => p.MaritalStatus);
            builder.Property(p => p.DateOfBirth).HasMaxLength(80);
            builder.Property(p => p.EmergencyContactNumber).HasMaxLength(11);
            builder.Property(p => p.PostalCode).HasMaxLength(20);
            builder.Property(p => p.SpouseNationalID).HasMaxLength(11);
            builder.Property(p => p.BloodType).HasMaxLength(20);
            builder.Property(p => p.MedicalHistory).HasMaxLength(200);


            #endregion

            #region Relation

            #endregion
        }
    }
}
