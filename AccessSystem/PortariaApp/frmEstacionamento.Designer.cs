
namespace PortariaApp
{
    partial class frmEstacionamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstacionamento));
            this.pnlOperacoes = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gpbDadosEstacionamento = new System.Windows.Forms.GroupBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblNumVaga = new System.Windows.Forms.Label();
            this.gpbDadosProprietario = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblApto = new System.Windows.Forms.Label();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.mkbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mkbCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.pnlOperacoes.SuspendLayout();
            this.gpbDadosEstacionamento.SuspendLayout();
            this.gpbDadosProprietario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOperacoes
            // 
            this.pnlOperacoes.BackColor = System.Drawing.Color.Silver;
            this.pnlOperacoes.Controls.Add(this.btnVoltar);
            this.pnlOperacoes.Controls.Add(this.btnPesquisar);
            this.pnlOperacoes.Controls.Add(this.btnExcluir);
            this.pnlOperacoes.Controls.Add(this.btnAlterar);
            this.pnlOperacoes.Controls.Add(this.btnCadastrar);
            this.pnlOperacoes.Location = new System.Drawing.Point(0, 488);
            this.pnlOperacoes.Name = "pnlOperacoes";
            this.pnlOperacoes.Size = new System.Drawing.Size(789, 74);
            this.pnlOperacoes.TabIndex = 20;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(632, 20);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(140, 40);
            this.btnVoltar.TabIndex = 24;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(475, 20);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(140, 40);
            this.btnPesquisar.TabIndex = 23;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(318, 20);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(140, 40);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(166, 20);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(140, 40);
            this.btnAlterar.TabIndex = 21;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(12, 20);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(140, 40);
            this.btnCadastrar.TabIndex = 20;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // gpbDadosEstacionamento
            // 
            this.gpbDadosEstacionamento.Controls.Add(this.txtCidade);
            this.gpbDadosEstacionamento.Controls.Add(this.lblCidade);
            this.gpbDadosEstacionamento.Controls.Add(this.txtPlaca);
            this.gpbDadosEstacionamento.Controls.Add(this.lblNumVaga);
            this.gpbDadosEstacionamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosEstacionamento.Location = new System.Drawing.Point(13, 12);
            this.gpbDadosEstacionamento.Name = "gpbDadosEstacionamento";
            this.gpbDadosEstacionamento.Size = new System.Drawing.Size(759, 206);
            this.gpbDadosEstacionamento.TabIndex = 21;
            this.gpbDadosEstacionamento.TabStop = false;
            this.gpbDadosEstacionamento.Text = "Dados da Vaga";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(80, 92);
            this.txtCidade.MaxLength = 200;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(246, 26);
            this.txtCidade.TabIndex = 6;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(27, 98);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(47, 20);
            this.lblCidade.TabIndex = 15;
            this.lblCidade.Text = "Local";
            // 
            // txtPlaca
            // 
            this.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaca.Location = new System.Drawing.Point(158, 39);
            this.txtPlaca.MaxLength = 7;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(104, 26);
            this.txtPlaca.TabIndex = 2;
            // 
            // lblNumVaga
            // 
            this.lblNumVaga.AutoSize = true;
            this.lblNumVaga.Location = new System.Drawing.Point(27, 45);
            this.lblNumVaga.Name = "lblNumVaga";
            this.lblNumVaga.Size = new System.Drawing.Size(125, 20);
            this.lblNumVaga.TabIndex = 0;
            this.lblNumVaga.Text = "Número da vaga";
            // 
            // gpbDadosProprietario
            // 
            this.gpbDadosProprietario.Controls.Add(this.textBox1);
            this.gpbDadosProprietario.Controls.Add(this.lblApto);
            this.gpbDadosProprietario.Controls.Add(this.txtNomeFunc);
            this.gpbDadosProprietario.Controls.Add(this.lblNomeFunc);
            this.gpbDadosProprietario.Controls.Add(this.mkbTelefone);
            this.gpbDadosProprietario.Controls.Add(this.lblTelefone);
            this.gpbDadosProprietario.Controls.Add(this.mkbCPF);
            this.gpbDadosProprietario.Controls.Add(this.lblCPF);
            this.gpbDadosProprietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosProprietario.Location = new System.Drawing.Point(13, 224);
            this.gpbDadosProprietario.Name = "gpbDadosProprietario";
            this.gpbDadosProprietario.Size = new System.Drawing.Size(759, 242);
            this.gpbDadosProprietario.TabIndex = 26;
            this.gpbDadosProprietario.TabStop = false;
            this.gpbDadosProprietario.Text = "Dados do morador";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(358, 150);
            this.textBox1.MaxLength = 200;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(87, 26);
            this.textBox1.TabIndex = 20;
            // 
            // lblApto
            // 
            this.lblApto.AutoSize = true;
            this.lblApto.Location = new System.Drawing.Point(250, 156);
            this.lblApto.Name = "lblApto";
            this.lblApto.Size = new System.Drawing.Size(102, 20);
            this.lblApto.TabIndex = 21;
            this.lblApto.Text = "Apartamento";
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(76, 93);
            this.txtNomeFunc.MaxLength = 200;
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(534, 26);
            this.txtNomeFunc.TabIndex = 18;
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Location = new System.Drawing.Point(21, 99);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(51, 20);
            this.lblNomeFunc.TabIndex = 19;
            this.lblNomeFunc.Text = "Nome";
            // 
            // mkbTelefone
            // 
            this.mkbTelefone.Location = new System.Drawing.Point(97, 150);
            this.mkbTelefone.Mask = "(00) 00000-0000";
            this.mkbTelefone.Name = "mkbTelefone";
            this.mkbTelefone.Size = new System.Drawing.Size(128, 26);
            this.mkbTelefone.TabIndex = 9;
            this.mkbTelefone.ValidatingType = typeof(System.DateTime);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(23, 156);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(71, 20);
            this.lblTelefone.TabIndex = 17;
            this.lblTelefone.Text = "Telefone";
            // 
            // mkbCPF
            // 
            this.mkbCPF.Location = new System.Drawing.Point(68, 35);
            this.mkbCPF.Mask = "000,000,000-00";
            this.mkbCPF.Name = "mkbCPF";
            this.mkbCPF.Size = new System.Drawing.Size(122, 26);
            this.mkbCPF.TabIndex = 11;
            this.mkbCPF.ValidatingType = typeof(System.DateTime);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(22, 41);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(40, 20);
            this.lblCPF.TabIndex = 4;
            this.lblCPF.Text = "CPF";
            // 
            // frmEstacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gpbDadosProprietario);
            this.Controls.Add(this.gpbDadosEstacionamento);
            this.Controls.Add(this.pnlOperacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEstacionamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portaria - Estacionamento";
            this.Load += new System.EventHandler(this.frmEstacionamento_Load);
            this.pnlOperacoes.ResumeLayout(false);
            this.gpbDadosEstacionamento.ResumeLayout(false);
            this.gpbDadosEstacionamento.PerformLayout();
            this.gpbDadosProprietario.ResumeLayout(false);
            this.gpbDadosProprietario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOperacoes;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox gpbDadosEstacionamento;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblNumVaga;
        private System.Windows.Forms.GroupBox gpbDadosProprietario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblApto;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.MaskedTextBox mkbTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox mkbCPF;
        private System.Windows.Forms.Label lblCPF;
    }
}