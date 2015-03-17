using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Simpress.CodeFirst.FluentApi.DataAccess.Models.Mapping
{
    public class TB_SEXOMap : EntityTypeConfiguration<TB_SEXO>
    {
        public TB_SEXOMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_SEXO);

            // Properties
            this.Property(t => t.DS_SEXO)
                .IsRequired()
                .HasMaxLength(9);

            this.Property(t => t.DS_TESTE)
                .IsRequired()
                .HasMaxLength(45);

            // Table & Column Mappings
            this.ToTable("TB_SEXO");
            this.Property(t => t.ID_SEXO).HasColumnName("ID_SEXO");
            this.Property(t => t.DS_SEXO).HasColumnName("DS_SEXO");
            this.Property(t => t.DS_TESTE).HasColumnName("DS_TESTE");
            this.Property(t => t.IT_TESTE).HasColumnName("IT_TESTE");
        }
    }
}
