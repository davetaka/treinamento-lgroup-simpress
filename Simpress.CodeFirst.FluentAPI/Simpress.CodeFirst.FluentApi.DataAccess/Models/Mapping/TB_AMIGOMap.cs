using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Simpress.CodeFirst.FluentApi.DataAccess.Models.Mapping
{
    public class TB_AMIGOMap : EntityTypeConfiguration<TB_AMIGO>
    {
        public TB_AMIGOMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_AMIGO);

            // Properties
            this.Property(t => t.NM_AMIGO)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.DS_EMAIL)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.NR_TELEFONE)
                .IsRequired()
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("TB_AMIGO");
            this.Property(t => t.ID_AMIGO).HasColumnName("ID_AMIGO");
            this.Property(t => t.ID_SEXO).HasColumnName("ID_SEXO");
            this.Property(t => t.NM_AMIGO).HasColumnName("NM_AMIGO");
            this.Property(t => t.DS_EMAIL).HasColumnName("DS_EMAIL");
            this.Property(t => t.NR_TELEFONE).HasColumnName("NR_TELEFONE");
            this.Property(t => t.DT_NASCIMENTO).HasColumnName("DT_NASCIMENTO");

            // Relationships
            this.HasRequired(t => t.TB_SEXO)
                .WithMany(t => t.TB_AMIGO)
                .HasForeignKey(d => d.ID_SEXO);

        }
    }
}
