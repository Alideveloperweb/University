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
            
            builder.HasIndex(p => p.Username).IsUnique(true);
            
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
            builder.Property(p => p.HireDate);
            builder.Property(p => p.Salary);
            builder.Property(p => p.IsActive);
            builder.Property(p => p.WeeklyWorkingHours);
            builder.Property(p => p.RemainingLeaveDays);
            builder.Property(p => p.Supervisor);
            builder.Property(p => p.PerformanceReview);

            #endregion

            
            #region Relation

            builder.HasOne(j => j.Job)
               .WithMany(e => e.Employees)
               .HasForeignKey(e => e.JobId).OnDelete(DeleteBehavior.Restrict); 


            builder.HasOne(e => e.Department)
                   .WithMany(d => d.Employees)
                   .HasForeignKey(e => e.DepartmentId)
                   .OnDelete(DeleteBehavior.Restrict);

            #endregion


        }
    }
}
