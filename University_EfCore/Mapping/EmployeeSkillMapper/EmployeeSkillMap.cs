using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_Domain.Associations;
using University_Domain.EmployeeEntities;

namespace University_EfCore.Mapping.EmployeeSkillMapper
{
    public class EmployeeSkillMap : IEntityTypeConfiguration<SkilsEmployee>
    {
        public void Configure(EntityTypeBuilder<SkilsEmployee> builder)
        {
            #region Properties

            builder.HasKey(se => new { se.EmployeeId,se.SkillsId});


            #endregion


            #region Relation

            builder.HasOne(es => es.Employee)
            .WithMany(e => e.SkilsEmployees)
            .HasForeignKey(es => es.EmployeeId).OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(es => es.Skill)
            .WithMany(s => s.SkilsEmployees)
            .HasForeignKey(es => es.SkillsId).OnDelete(DeleteBehavior.Restrict);



            #endregion
        }
    }
}
