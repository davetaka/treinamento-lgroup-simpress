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
    public sealed class ClienteRepository : IClienteRepository
    {
        private Conexao _conexao = new Conexao();

        public ICollection<ClienteModel> Listar()
        {
            return _conexao.Clientes.ToList();
        }

        public ICollection<ClienteModel> Pesquisar(Expression<Func<ClienteModel, bool>> criterio)
        {
            return _conexao.Clientes.Where(criterio).ToList();
        }

        public void Cadastrar(ClienteModel entidade)
        {
            _conexao.Clientes.Add(entidade);
            _conexao.SaveChanges();
        }

        public void Atualizar(ClienteModel entidade)
        {
            _conexao.Entry(entidade).State = System.Data.Entity.EntityState.Modified;
            _conexao.SaveChanges();    
        }

        public void Deletar(int codigo)
        {
            var cliente = _conexao.Clientes.Find(codigo);
            _conexao.Clientes.Remove(cliente);
            _conexao.SaveChanges();
        }
    }
}
