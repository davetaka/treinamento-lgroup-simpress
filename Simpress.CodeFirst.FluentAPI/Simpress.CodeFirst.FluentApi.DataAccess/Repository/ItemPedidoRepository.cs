using Simpress.CodeFirst.FluentApi.Model;
using Simpress.CodeFirst.FluentApi.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Simpress.CodeFirst.FluentApi.DataAccess.Repository
{
    public sealed class ItemPedidoRepository : IItemPedidoRepository
    {
        private Conexao _conexao = new Conexao();

        public ICollection<ItemPedidoModel> Listar()
        {
            return _conexao.ItemPedidos.ToList();
        }

        public ICollection<ItemPedidoModel> Pesquisar(Expression<Func<ItemPedidoModel, bool>> criterio)
        {
            return _conexao.ItemPedidos.Where(criterio).ToList();
        }
    }
}
