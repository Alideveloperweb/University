using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_Domain.SkillsEntities;

namespace University_EfCore.Mapping.SkillsMapper
{
    public class SkillsMap : IEntityTypeConfiguration<Skills>
    {
        public void Configure(EntityTypeBuilder<Skills> builder)
        {
            #region Properties

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).HasMaxLength(30);

            #endregion


            #region Relation



            #endregion

        }
    }
}
