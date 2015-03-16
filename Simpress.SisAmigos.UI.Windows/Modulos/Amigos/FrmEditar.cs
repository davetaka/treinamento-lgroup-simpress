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
    public partial class FrmEditar : Form
    {
        public int codigo;

        public FrmEditar()
        {
            InitializeComponent();
        }

        private void btnTabela_Click(object sender, EventArgs e)
        {
            var conexao = new SIMPRESSEntities();

            conexao.Database.Log = (log) =>
            {
                Console.WriteLine(log);
            };

            var novoAmigo = conexao.TB_AMIGO.Find(codigo);

            novoAmigo.NM_AMIGO = txtNome.Text;
            //novoAmigo.DS_EMAIL = txtEmail.Text;
            //novoAmigo.DT_NASCIMENTO = dtpNascimento.Value;
            //novoAmigo.NR_TELEFONE = mskTelefone.Text;
            //novoAmigo.ID_SEXO = 1;

            conexao.SaveChanges();


            MessageBox.Show("Código: " + novoAmigo.ID_AMIGO);


        }

        private void btnProcedure_Click(object sender, EventArgs e)
        {
            var conexao = new SIMPRESSEntities();

            conexao.INSERIR_AMIGO(txtNome.Text, txtEmail.Text, mskTelefone.Text, dtpNascimento.Value);
            conexao.SaveChanges();

            MessageBox.Show("Cadastrado com sucesso!");
        }

        private void btnTsql_Click(object sender, EventArgs e)
        {
            var conexao = new SIMPRESSEntities();
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

        private void FrmEditar_Load(object sender, EventArgs e)
        {
            var conexao = new SIMPRESSEntities();

        }
    }
}
