using Simpress.CodeFirst.FluentApi.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpress.CodeFirst.FluentApi.DataAccess.Mapping
{
    public class ItemPedidoMapping : EntityTypeConfiguration<ItemPedidoModel>
    {
        public ItemPedidoMapping()
        {
            ToTable("TB_ITEM_PEDIDO");
            HasKey(x => x.Codigo);

            Property(x => x.Codigo)
                .HasColumnName("ID_ITEM_PEDIDO")
                .HasColumnType("INT");

            Property(x => x.CodigoPedido)
                .HasColumnName("ID_PEDIDO")
                .HasColumnType("INT")
                .IsRequired();

            Property(x => x.CodigoProduto)
                .HasColumnName("ID_PRODUTO")
                .HasColumnType("INT")
                .IsRequired();

            Property(x => x.DataCadastro)
                .HasColumnName("DT_CADASTRO")
                .HasColumnType("DATETIME")
                .IsRequired();

            Property(x => x.Quantidade)
                .HasColumnName("NR_PRODUTOS")
                .HasColumnType("INT")
                .IsRequired();

            Property(x => x.Valor)
                .HasColumnName("VL_PRODUTO")
                .HasColumnType("DECIMAL")
                .HasPrecision(8,2)
                .IsRequired();

            //FK
            //Criamos um relacionamento obrigatorio entre as classes
            //a classe itempedido conversa com a classe pedido
            //atraves do campo CodigoPedido
            HasRequired(x => x.Pedido)
                .WithMany()
                .HasForeignKey(x => x.CodigoPedido);

            HasRequired(x => x.Produto)
                .WithMany()
                .HasForeignKey(x => x.CodigoProduto);
        }
    }
}
