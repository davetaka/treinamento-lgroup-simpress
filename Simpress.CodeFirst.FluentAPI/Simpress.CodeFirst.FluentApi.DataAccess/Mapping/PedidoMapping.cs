using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Subimos as classes de armazenamento de dados pra memoria
//elas vao virar tabelas
using Simpress.CodeFirst.FluentApi.Model;

//Todas as clases que vao nos auxiliar a dar o nome da tabela
//dar o nome, tamanho e tipo dos campos descem dessa namespace
using System.Data.Entity.ModelConfiguration;

namespace Simpress.CodeFirst.FluentApi.DataAccess.Mapping
{
    public class PedidoMapping : EntityTypeConfiguration<PedidoModel>
    {
        public PedidoMapping()
        {
            //Definimos o nome da tabela
            ToTable("TB_PEDIDO");
            //Definimos os campos que são chave primária
            HasKey(x => x.Codigo);
            
            Property(x => x.Codigo)
                .HasColumnName("ID_PEDIDO")
                .HasColumnType("INT");

            Property(x => x.CodigoCliente)
                .HasColumnName("ID_CLIENTE")
                .HasColumnType("INT")
                .IsRequired();

            Property(x => x.DataCadastro)
                .HasColumnName("DT_CADASTRO")
                .HasColumnType("DATETIME")
                .IsRequired();

            Property(x=>x.Observacao)
                .HasColumnName("DS_OBSERVACAO")
                .HasColumnType("VARCHAR")
                .HasMaxLength(250)
                .IsRequired();

            //Foi nesse momento que definimos o relacionamento 
            //entre as classes

            //Cuidado
            //Ao desenhar as tabelas pelo sql server por padrão
            //a exclusao em cascata vem desabilitada
            //quando montamos as tabelas via code first o padrão
            //é vir com a exlusao em cascata habilitada (PERIGOSO)
            HasRequired(x => x.Cliente)
                .WithMany()
                .HasForeignKey(x => x.CodigoCliente);
        }
    }
}
