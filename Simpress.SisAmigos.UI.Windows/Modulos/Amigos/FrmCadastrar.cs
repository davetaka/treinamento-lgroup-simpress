using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simpress.SisAmigos.UI.Windows.Modulos.Amigos
{
    public partial class FrmCadastrar : Form
    {
        public FrmCadastrar()
        {
            InitializeComponent();
        }

        private void btnTabela_Click(object sender, EventArgs e)
        {
            //o entity framework é uma ferramenta de acesso e manipulação de dados
            //é o que tem de mais top desde 2008 para acesso a dados
            //esquece o modelo conectado e vá de ef
            //novidade do visual studio 2013(temos 2 versões do EF)
            //5.0 e 6.0
            //Estamos utilizando a forma(Estratégia) DATABASE FIRST
            //O EF nada mais é do que um XML gigantesco pra ficar bunitinho de olhar tem o EF Designer

            //a classe de conexao (Classe de contexto do EF sempre termina com Entities)
            //Padrao de nomenclatura sempre o NOMEDOBANCOEntities
            var conexao = new SIMPRESSEntities();

            //a unica forma de entender bastidores do EF
            //é monitorando o LOG (tunning de query, entendimento)

#warning voltar amanha e testar com 2013 ou 2012

            //CONSIDERAÇÕES por tras do EF utiliza o modelo conectado
            //ele abre e fecha automaticamente a conexao
            //ele faz o begin, commit, rollback
            //using so serve para liberar memoria, hd, processador e todos os recursos utilizados internamentes
            conexao.Database.Log = (log) =>
            {
                //pra escrever alguma informacao de monitoramento de codigo
                Console.WriteLine(log);
            };


            //fizemos o mapeamento da tabela de AMIGOS
            //cada tabela foi mapeada em forma de 1 CLASSE
            var novoAmigo = new TB_AMIGO();

            //da mesma forma que temos um ciclo de vida
            //temos um ciclo de vida para os registros
            //conseguimos visualizar os estados deles
            var estadoInicial = conexao.Entry(novoAmigo).State;

            //DATA MAPPER é o nome bonitão de pegar dados de um local e levar para outro
            novoAmigo.NM_AMIGO = txtNome.Text;
            novoAmigo.DS_EMAIL = txtEmail.Text;
            novoAmigo.DT_NASCIMENTO = dtpNascimento.Value;
            novoAmigo.NR_TELEFONE = mskTelefone.Text;
            novoAmigo.ID_SEXO = 1;

            //apos fazer a movimentacao de dados mandamos na tabela
            //inserir na tabela
            conexao.TB_AMIGO.Add(novoAmigo);
            var estadoIntermediario = conexao.Entry(novoAmigo).State;

            //é esse comando que leva os dados para o banco
            //é no savechanges que ele faz o insert e levar o registro pro banco (consultar log)
            conexao.SaveChanges();
            var estadoFinal = conexao.Entry(novoAmigo).State;


            //Malandragem do EF quando mandamos inserir um registro
            //ele sempre retorna o codigo daquele registro(IDENTITY)
            MessageBox.Show("Código: " + novoAmigo.ID_AMIGO);

            //DETACHED significa que o registro esta na memoria, no cache e não está na tabela
            //ADDED registro na fila para ser inserido
            //UNCHANGED registro nao sofreu alterações

        }

        private void btnProcedure_Click(object sender, EventArgs e)
        {
            //o melhor dos mundos é ENTITY FRAMEWORK com PROCEDURE
            //ganhamos a produtividade do EF e a performance do banco
            //são mais rapidas que comandos tsql ADHOCK
            var conexao = new SIMPRESSEntities();

            conexao.INSERIR_AMIGO(txtNome.Text, txtEmail.Text, mskTelefone.Text, dtpNascimento.Value);
            conexao.SaveChanges();

            MessageBox.Show("Cadastrado com sucesso!");
        }

        private void btnTsql_Click(object sender, EventArgs e)
        {
            var conexao = new SIMPRESSEntities();
            // Tomar cuidado ao concatenar STRINGS (MA PRATICA)
            // Utilizar sempre uma STRINGBUILDER(+RAPIDO)
            // Todos os textos vão para o mesmo endereco de memoria
            var stringona = new StringBuilder();
            stringona.AppendLine("INSERT INTO dbo.TB_AMIGO");
            stringona.AppendLine("(NM_AMIGO, DS_EMAIL,NR_TELEFONE,DT_NASCIMENTO,ID_SEXO)");
            stringona.AppendLine("VALUES('{0}', '{1}', '{2}', '{3}', '{4}')");

            var tSql = String.Format(stringona.ToString(),
                                    txtEmail.Text,
                                    txtEmail.Text,
                                    mskTelefone.Text,
                                    dtpNascimento.Value.ToString("yyyy-MM-dd hh:mm:ss"),
                                    2);

            conexao.Database.ExecuteSqlCommand(tSql);


        }

        private async void CadastrarAsync()
        {
            var conexao = new SIMPRESSEntities();

            conexao.Database.Log = (log) =>
            {
                Console.WriteLine(log);
            };


            var novoAmigo = new TB_AMIGO();

            var estadoInicial = conexao.Entry(novoAmigo).State;

            novoAmigo.NM_AMIGO = txtNome.Text;
            novoAmigo.DS_EMAIL = txtEmail.Text;
            novoAmigo.DT_NASCIMENTO = dtpNascimento.Value;
            novoAmigo.NR_TELEFONE = mskTelefone.Text;
            novoAmigo.ID_SEXO = 1;

            conexao.TB_AMIGO.Add(novoAmigo);
            var estadoIntermediario = conexao.Entry(novoAmigo).State;

            await conexao.SaveChangesAsync();
            var estadoFinal = conexao.Entry(novoAmigo).State;


            MessageBox.Show("Código: " + novoAmigo.ID_AMIGO);

        }


        private void btnAssincrono_Click(object sender, EventArgs e)
        {
            CadastrarAsync();
            var migue = "ai sim hein fag";
        }
    }
}
