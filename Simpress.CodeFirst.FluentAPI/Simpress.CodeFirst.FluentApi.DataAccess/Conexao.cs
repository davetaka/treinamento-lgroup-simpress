using Simpress.CodeFirst.FluentApi.DataAccess.Mapping;
using Simpress.CodeFirst.FluentApi.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpress.CodeFirst.FluentApi.DataAccess
{
    public sealed class Conexao : DbContext
    {
        public Conexao()
            : base("Data Source=.;Initial Catalog=FLUENTAPI;Integrated Security=True")
        {

        }

        public void CriarBanco()
        {
            Database.Create();
        }

        public void RemoverBanco()
        {
            Database.Delete();
        }

        public DbSet<ItemPedidoModel> ItemPedidos { get; set; }
        public DbSet<PedidoModel> Pedidos { get; set; }
        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<ProdutoModel> Produtos { get; set; }

        //Lá no dataannotations pra gerar as tabelas era dbset
        //aqui no fluentapi pra gerar as tabelas temos que
        //chamar o comando onmodelcreating
        //o comando abaixo desceu da classe dbcontext (PAI)
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Foi nesse momento que mandamos gerar o banco
            //juntamente com as tabelas, equivaleria a um
            //Create table
            modelBuilder.Configurations.Add(new ClienteMapping());
            modelBuilder.Configurations.Add(new PedidoMapping());
            modelBuilder.Configurations.Add(new ProdutoMapping());
            modelBuilder.Configurations.Add(new ItemPedidoMapping());
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
