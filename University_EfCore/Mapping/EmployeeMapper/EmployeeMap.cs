using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University_Domain.EmployeeEntities;
using University_Domain.JobEntities;

namespace University_EfCore.Mapping.EmployeeMapper
{
    public class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
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
            builder.Property(p => p.SpouseNationalID).HasMaxLength(11);
            builder.Property(p => p.BloodType).HasMaxLength(20);
            builder.Property(p => p.MedicalHistory).HasMaxLength(200);
            builder.Property(p => p.EmployeeNumber).HasMaxLength(200);
            builder.Property(p => p.Department).HasMaxLength(50);
            builder.Property(p => p.HireDate);
            builder.Property(p => p.Salary);
            builder.Property(p => p.EmploymentStatus);
            builder.Property(p => p.WeeklyWorkingHours);
            builder.Property(p => p.RemainingLeaveDays);
            builder.Property(p => p.Supervisor);
            builder.Property(p => p.Skills);
            builder.Property(p => p.Certifications);
            builder.Property(p => p.PerformanceReview);
            builder.Property(p => p.RecentProjects);

            #endregion

            
            #region Relation
            builder.HasOne(j => j.Job)
               .WithMany(e => e.Employees)
               .HasForeignKey(e => e.JobId);

            #endregion


        }
    }
}
