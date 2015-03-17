using Simpress.CodeFirst.FluentApi.DataAccess.Repository;
using Simpress.CodeFirst.FluentApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpress.CodeFirst.FluentApi.Service
{
    public sealed class ClienteService : IClienteService
    {
        private ClienteRepository _repositorio = new ClienteRepository();

        public ICollection<ClienteModel> ListarClientes()
        {
            return _repositorio.Listar();
        }

        public void CadastrarCliente(ClienteModel entidade)
        {
            _repositorio.Cadastrar(entidade);
        }
    }
}
