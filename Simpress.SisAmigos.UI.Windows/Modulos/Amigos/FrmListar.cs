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
    public partial class FrmListar : Form
    {
        private SIMPRESSEntities _conexao = new SIMPRESSEntities();

        public FrmListar()
        {
            _conexao.Database.Log = (log) => Console.Write(log);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //select seco
            dataGridView1.DataSource = _conexao.TB_AMIGO.ToList();

            _conexao.TB_AMIGO.Select(x => new { Nome = x.NM_AMIGO });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //select alguns campos
            dataGridView1.DataSource = _conexao.TB_AMIGO.Select(a => new { a.NM_AMIGO });
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //boladao de operadores
            //efetuamos uma consulta mais realista utilizamos linq to entities (consultas dentro do EF)
            //CONSIDERAÇÕES
            //select sempre no final
            DateTime dataAtual = DateTime.Now;


            dataGridView1.DataSource = _conexao.TB_AMIGO
                .Where(x => x.ID_AMIGO >= 1
                    && (x.ID_SEXO == 1 || x.ID_SEXO == 2)
                    && x.NM_AMIGO.Contains("a")
                    && x.DT_NASCIMENTO <= dataAtual
                ).OrderBy(x => new { x.NM_AMIGO, x.DS_EMAIL })
                .ThenByDescending(x => new { x.DT_NASCIMENTO, x.ID_SEXO })
                .Select(x => new { Id = x.ID_AMIGO, Nome = x.NM_AMIGO, Email = x.DS_EMAIL, Sexo = x.TB_SEXO.DS_SEXO }).ToList();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _conexao.ListarAmigos();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _conexao.TotalAmigos();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            var amigo = _conexao.TB_AMIGO.Find(codigo);

            _conexao.TB_AMIGO.Remove(amigo);
            _conexao.SaveChanges();
        }

        private void button19_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = (from a in _conexao.TB_AMIGO
                                        select new
                                        {
                                            Nome = a.NM_AMIGO,
                                            Sexo = a.TB_SEXO.DS_SEXO
                                        }).ToList();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            FrmEditar edit = new FrmEditar();
            edit.codigo = codigo;

            edit.ShowDialog();
        }
    }
}
