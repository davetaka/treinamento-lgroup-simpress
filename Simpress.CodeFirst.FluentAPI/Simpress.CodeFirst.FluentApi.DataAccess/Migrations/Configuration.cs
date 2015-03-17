namespace Simpress.CodeFirst.FluentApi.DataAccess.Migrations
{
    using Simpress.CodeFirst.FluentApi.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    //Code first migrations existe desde ef 4.3
    //serve pra gerenciar a evolução das tabelas e campos
    //ele vai guardando backups dos nomes das tabelas e campos
    //de tabela, a grosso modo é tipo um checkin checkout no tfs
    internal sealed class Configuration : DbMigrationsConfiguration<Simpress.CodeFirst.FluentApi.DataAccess.Conexao>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Simpress.CodeFirst.FluentApi.DataAccess.Conexao";
        }

        protected override void Seed(Simpress.CodeFirst.FluentApi.DataAccess.Conexao context)
        {
            context.Clientes.AddOrUpdate(c => c.Codigo,
                new ClienteModel
                {
                    Codigo = 1,
                    Nome = "Eu",
                    Telefone = "11111111",
                    CPF = "12345678978",
                    DataNascimento = DateTime.Now,
                    Endereco = "Endereco",
                    Email = "email",
                    DataCadastro = DateTime.Now
                }
            );


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
