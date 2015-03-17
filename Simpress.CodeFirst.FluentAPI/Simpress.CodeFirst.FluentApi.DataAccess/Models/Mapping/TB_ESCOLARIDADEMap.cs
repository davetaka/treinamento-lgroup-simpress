using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Simpress.CodeFirst.FluentApi.DataAccess.Models.Mapping
{
    public class TB_ESCOLARIDADEMap : EntityTypeConfiguration<TB_ESCOLARIDADE>
    {
        public TB_ESCOLARIDADEMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_ESCOLARIDADE);

            // Properties
            this.Property(t => t.DS_ESCOLARIDADE)
                .IsRequired()
                .HasMaxLength(35);

            // Table & Column Mappings
            this.ToTable("TB_ESCOLARIDADE");
            this.Property(t => t.ID_ESCOLARIDADE).HasColumnName("ID_ESCOLARIDADE");
            this.Property(t => t.DS_ESCOLARIDADE).HasColumnName("DS_ESCOLARIDADE");
        }
    }
}
