using Simpress.CodeFirst.FluentApi.DataAccess.Repository;
using Simpress.CodeFirst.FluentApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpress.CodeFirst.FluentApi.Service
{
    public sealed class PedidoService : IPedidoService
    {
        private PedidoRepository _repositorio = new PedidoRepository();

        public ICollection<PedidoModel> ListarPedidos()
        {
            return _repositorio.Listar();
        }

        public void CadastrarPedido(PedidoModel entidade)
        {
            _repositorio.Cadastrar(entidade);
        }
    }
}
