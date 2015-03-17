using Simpress.CodeFirst.FluentApi.Model;
using Simpress.CodeFirst.FluentApi.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Simpress.Service.Controllers
{
    public class ClienteController : ApiController
    {
        ClienteService _servico = new ClienteService();

        [HttpGet]
        public IEnumerable<ClienteModel> Listar()
        {
            return _servico.ListarClientes();
        }

        [HttpPost]
        public void Cadastrar(ClienteModel entidade)
        {
            _servico.CadastrarCliente(entidade);
        }
    }
}
