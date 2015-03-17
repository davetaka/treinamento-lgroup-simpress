using Simpress.CodeFirst.FluentApi.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpress.CodeFirst.FluentApi.DataAccess.Mapping
{
    //Estamos fazendo a geração e mapeamento do banco
    //com ef via fluent api
    //é a forma preferida dos programadores, temos um controle
    //total do codigo (sem limitações (campo decimal, n pra n))
    //fica inclusive muito mais clean, nao fica baguncado o codigo
    //fluent api siginifica que vamos os mapeamentos em forma
    //de expressoes lambdas (x=>x)
    public class ClienteMapping : EntityTypeConfiguration<ClienteModel>
    {

        public ClienteMapping()
        {
            ToTable("TB_CLIENTE");
            HasKey(x => x.Codigo);

            Property(x => x.Codigo)
                .HasColumnName("ID_CLIENTE")
                .HasColumnType("INT");

            Property(x => x.DataCadastro)
              .HasColumnName("DT_CADASTRO")
              .HasColumnType("DATETIME")
              .IsRequired();

            Property(x => x.DataNascimento)
              .HasColumnName("DT_NASCIMENTO")
              .HasColumnType("DATETIME")
              .IsRequired();

            Property(x => x.Email)
                          .HasColumnName("DS_EMAIL")
                          .HasColumnType("VARCHAR")
                          .HasMaxLength(50)
                          .IsRequired();

            Property(x => x.Nome)
              .HasColumnName("NM_NOME")
              .HasColumnType("VARCHAR")
              .HasMaxLength(30)
              .IsRequired();

            Property(x => x.Telefone)
              .HasColumnName("NR_TELEFONE")
              .HasColumnType("VARCHAR")
              .HasMaxLength(15)
              .IsRequired();

            Property(x => x.Endereco)
             .HasColumnName("DS_ENDERECO")
             .HasColumnType("VARCHAR")
             .HasMaxLength(50);

            Property(x => x.CPF)
             .HasColumnName("NR_CPF")
             .HasColumnType("VARCHAR")
             .HasMaxLength(14);

        }

    }
}
