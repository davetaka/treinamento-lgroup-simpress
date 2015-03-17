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
    public sealed class PedidoRepository : IPedidoRepository
    {
        private Conexao _conexao = new Conexao();
        public ICollection<PedidoModel> Listar()
        {
            return _conexao.Pedidos.ToList();
        }

        public ICollection<PedidoModel> Pesquisar(Expression<Func<PedidoModel, bool>> criterio)
        {
            return _conexao.Pedidos.Where(criterio).ToList();
        }

        public void Cadastrar(PedidoModel entidade)
        {
            _conexao.Pedidos.Add(entidade);
            _conexao.SaveChanges();
        }

        public void Atualizar(PedidoModel entidade)
        {
            _conexao.Entry(entidade).State = System.Data.Entity.EntityState.Modified;
            _conexao.SaveChanges();    
        }

        public void Deletar(int codigo)
        {
            var pedido = _conexao.Pedidos.Find(codigo);
            _conexao.Pedidos.Remove(pedido);
            _conexao.SaveChanges();

        }
    }
}
