using Simpress.CodeFirst.FluentApi.Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpress.CodeFirst.FluentApi.Model
{
    public sealed class ItemPedidoModel : BaseModel
    {
        public Int32 CodigoPedido { get; set; }
        public Int32 CodigoProduto { get; set; }
        public Int32 Quantidade { get; set; }
        public Decimal Valor { get; set; }

        public PedidoModel Pedido { get; set; }

        public ProdutoModel Produto { get; set; }
    }
}
