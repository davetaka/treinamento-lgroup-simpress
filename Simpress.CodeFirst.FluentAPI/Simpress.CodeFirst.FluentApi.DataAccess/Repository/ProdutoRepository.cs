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
    public sealed class ProdutoRepository : IProdutoRepository
    {
        private Conexao _conexao = new Conexao();
        public ICollection<ProdutoModel> Listar()
        {
            return _conexao.Produtos.ToList();
        }

        public ICollection<ProdutoModel> Pesquisar(Expression<Func<ProdutoModel, bool>> criterio)
        {
            return _conexao.Produtos.Where(criterio).ToList();
        }

        public void Cadastrar(ProdutoModel entidade)
        {
            _conexao.Produtos.Add(entidade);
            _conexao.SaveChanges();
        }

        public void Atualizar(ProdutoModel entidade)
        {
            _conexao.Entry(entidade).State = System.Data.Entity.EntityState.Modified;
            _conexao.SaveChanges();    
        }

        public void Deletar(int entidade)
        {
            var produto = _conexao.Produtos.Find(entidade);
            _conexao.Produtos.Remove(produto);
            _conexao.SaveChanges();
        }
    }
}
