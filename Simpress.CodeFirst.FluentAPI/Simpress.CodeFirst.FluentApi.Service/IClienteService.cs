using Simpress.CodeFirst.FluentApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpress.CodeFirst.FluentApi.Service
{
    public interface IClienteService
    {

        ICollection<ClienteModel> ListarClientes();

        void CadastrarCliente(ClienteModel entidade);
    }
}
