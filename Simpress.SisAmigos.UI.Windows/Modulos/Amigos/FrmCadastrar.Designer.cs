namespace Simpress.SisAmigos.UI.Windows.Modulos.Amigos
{
    partial class FrmCadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.btnTransacional = new System.Windows.Forms.Button();
            this.btnTsql = new System.Windows.Forms.Button();
            this.btnTabela = new System.Windows.Forms.Button();
            this.btnProcedure = new System.Windows.Forms.Button();
            this.btnAssincrono = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de Nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sexo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(158, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(158, 49);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(158, 81);
            this.mskTelefone.Mask = "(99) 99999-9999";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(100, 20);
            this.mskTelefone.TabIndex = 7;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(158, 112);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(100, 20);
            this.dtpNascimento.TabIndex = 8;
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(158, 141);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(100, 21);
            this.cboSexo.TabIndex = 9;
            // 
            // btnTransacional
            // 
            this.btnTransacional.Location = new System.Drawing.Point(150, 165);
            this.btnTransacional.Name = "btnTransacional";
            this.btnTransacional.Size = new System.Drawing.Size(124, 23);
            this.btnTransacional.TabIndex = 10;
            this.btnTransacional.Text = "Cadastrar Transacional";
            this.btnTransacional.UseVisualStyleBackColor = true;
            // 
            // btnTsql
            // 
            this.btnTsql.Location = new System.Drawing.Point(12, 196);
            this.btnTsql.Name = "btnTsql";
            this.btnTsql.Size = new System.Drawing.Size(115, 23);
            this.btnTsql.TabIndex = 12;
            this.btnTsql.Text = "Cadastrar TSQL";
            this.btnTsql.UseVisualStyleBackColor = true;
            this.btnTsql.Click += new System.EventHandler(this.btnTsql_Click);
            // 
            // btnTabela
            // 
            this.btnTabela.Location = new System.Drawing.Point(12, 225);
            this.btnTabela.Name = "btnTabela";
            this.btnTabela.Size = new System.Drawing.Size(115, 23);
            this.btnTabela.TabIndex = 13;
            this.btnTabela.Text = "Cadastrar Tabela\r\n";
            this.btnTabela.UseVisualStyleBackColor = true;
            this.btnTabela.Click += new System.EventHandler(this.btnTabela_Click);
            // 
            // btnProcedure
            // 
            this.btnProcedure.Location = new System.Drawing.Point(12, 165);
            this.btnProcedure.Name = "btnProcedure";
            this.btnProcedure.Size = new System.Drawing.Size(115, 25);
            this.btnProcedure.TabIndex = 14;
            this.btnProcedure.Text = "Cadastrar Procedure";
            this.btnProcedure.UseVisualStyleBackColor = true;
            this.btnProcedure.Click += new System.EventHandler(this.btnProcedure_Click);
            // 
            // btnAssincrono
            // 
            this.btnAssincrono.Location = new System.Drawing.Point(150, 196);
            this.btnAssincrono.Name = "btnAssincrono";
            this.btnAssincrono.Size = new System.Drawing.Size(124, 23);
            this.btnAssincrono.TabIndex = 15;
            this.btnAssincrono.Text = "Cadastrar Assincrono";
            this.btnAssincrono.UseVisualStyleBackColor = true;
            this.btnAssincrono.Click += new System.EventHandler(this.btnAssincrono_Click);
            // 
            // FrmCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAssincrono);
            this.Controls.Add(this.btnProcedure);
            this.Controls.Add(this.btnTabela);
            this.Controls.Add(this.btnTsql);
            this.Controls.Add(this.btnTransacional);
            this.Controls.Add(this.cboSexo);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastrar";
            this.Text = "FrmCadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Button btnTransacional;
        private System.Windows.Forms.Button btnTsql;
        private System.Windows.Forms.Button btnTabela;
        private System.Windows.Forms.Button btnProcedure;
        private System.Windows.Forms.Button btnAssincrono;
    }
}