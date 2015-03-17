using Simpress.CodeFirst.FluentApi.DataAccess.Repository;
using Simpress.CodeFirst.FluentApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpress.CodeFirst.FluentApi.Service
{
    public interface IPedidoService
    {

        ICollection<PedidoModel> ListarPedidos();

        void CadastrarPedido(PedidoModel entidade);
    }
}
