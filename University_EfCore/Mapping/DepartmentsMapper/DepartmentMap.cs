using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_Domain.DepartmentsEntities;
using University_Domain.EmployeeEntities;

namespace University_EfCore.Mapping.DepartmentsMapper
{
    public class DepartmentMap : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            #region Properties

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).HasMaxLength(20);


            #endregion


            #region Relation

            builder.HasMany(d => d.Employees)
                   .WithOne(e => e.Department)
                   .HasForeignKey(e => e.DepartmentId)
                   .OnDelete(DeleteBehavior.Restrict);

            #endregion


        }
    }
}
