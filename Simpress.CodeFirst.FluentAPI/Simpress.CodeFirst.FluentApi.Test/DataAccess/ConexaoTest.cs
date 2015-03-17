using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Simpress.CodeFirst.FluentApi.DataAccess;

namespace Simpress.CodeFirst.FluentApi.Test.DataAccess
{
    [TestFixture]
    class ConexaoTest
    {
        private Conexao _conexao = new Conexao();

        [Test]
        public void Testar_Criacao_Do_Banco()
        {
            _conexao.CriarBanco();
        }

        [Test]
        public void Testar_Exclusao_Do_Banco()
        {
            _conexao.RemoverBanco();
        }

        [Test]
        public void Testar_Exibicao_De_Cliente()
        {
            var clientes = _conexao.Clientes.ToList();
        }
    }
}
