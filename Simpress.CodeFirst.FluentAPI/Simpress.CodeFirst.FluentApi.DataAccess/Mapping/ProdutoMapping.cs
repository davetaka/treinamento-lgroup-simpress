using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Subimos pra memoria a dll de armazenamento de dados
//as classes que vao virar tabelas ficam aqui dentro
using Simpress.CodeFirst.FluentApi.Model;

//Essa namespace vai habilitar a classe entitytypeconfiguration
using System.Data.Entity.ModelConfiguration;


namespace Simpress.CodeFirst.FluentApi.DataAccess.Mapping
{
    public class ProdutoMapping : EntityTypeConfiguration<ProdutoModel>
    {
        public ProdutoMapping()
        {
            ToTable("TB_PRODUTO");
            HasKey(x => x.Codigo);

            Property(x => x.Codigo).HasColumnName("ID_PRODUTO")
                .HasColumnType("INT");

            Property(x => x.DataCadastro).HasColumnName("DT_CADASTRO")
                .HasColumnType("DATETIME")
                .IsRequired();

            Property(x => x.Descricao).HasColumnName("DS_PRODUTO")
                .HasColumnType("VARCHAR")
                .HasMaxLength(250)
                .IsRequired();

            Property(x => x.Nome).HasColumnName("NM_PRODUTO")
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired();

            Property(x => x.Status).HasColumnName("FLG_STATUS")
                .HasColumnType("BIT")
                .IsRequired();

            Property(x => x.Valor).HasColumnName("VL_PRODUTO")
               .HasColumnType("DECIMAL")
               .HasPrecision(8,2)
               .IsRequired();

            Property(x => x.Fornecedor).HasColumnName("NM_FORNECEDOR")
                .HasColumnType("VARCHAR")
                .IsRequired();

            Property(x => x.Fabricante).HasColumnName("NM_FABRICANTE")
                .HasColumnType("VARCHAR")
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}