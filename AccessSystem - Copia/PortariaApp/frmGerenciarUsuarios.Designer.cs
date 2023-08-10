
namespace PortariaApp
{
    partial class frmGerenciarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarUsuarios));
            this.txtNomeUsu = new System.Windows.Forms.TextBox();
            this.lblUsuariol = new System.Windows.Forms.Label();
            this.gpbDadosUsuarios = new System.Windows.Forms.GroupBox();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmaSenha = new System.Windows.Forms.Label();
            this.txtSenhaUsu = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pnlOperacoes = new System.Windows.Forms.Panel();
            this.gpbDadosFuncionarios = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblRegisto = new System.Windows.Forms.Label();
            this.cbbCodigo = new System.Windows.Forms.ComboBox();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gpbDadosUsuarios.SuspendLayout();
            this.pnlOperacoes.SuspendLayout();
            this.gpbDadosFuncionarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeUsu
            // 
            this.txtNomeUsu.Location = new System.Drawing.Point(258, 39);
            this.txtNomeUsu.MaxLength = 50;
            this.txtNomeUsu.Name = "txtNomeUsu";
            this.txtNomeUsu.Size = new System.Drawing.Size(248, 26);
            this.txtNomeUsu.TabIndex = 4;
            // 
            // lblUsuariol
            // 
            this.lblUsuariol.AutoSize = true;
            this.lblUsuariol.Location = new System.Drawing.Point(188, 45);
            this.lblUsuariol.Name = "lblUsuariol";
            this.lblUsuariol.Size = new System.Drawing.Size(64, 20);
            this.lblUsuariol.TabIndex = 2;
            this.lblUsuariol.Text = "Usuário";
            // 
            // gpbDadosUsuarios
            // 
            this.gpbDadosUsuarios.Controls.Add(this.txtConfirmaSenha);
            this.gpbDadosUsuarios.Controls.Add(this.lblConfirmaSenha);
            this.gpbDadosUsuarios.Controls.Add(this.txtSenhaUsu);
            this.gpbDadosUsuarios.Controls.Add(this.lblSenha);
            this.gpbDadosUsuarios.Controls.Add(this.txtNomeUsu);
            this.gpbDadosUsuarios.Controls.Add(this.lblUsuariol);
            this.gpbDadosUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosUsuarios.Location = new System.Drawing.Point(12, 124);
            this.gpbDadosUsuarios.Name = "gpbDadosUsuarios";
            this.gpbDadosUsuarios.Size = new System.Drawing.Size(760, 180);
            this.gpbDadosUsuarios.TabIndex = 0;
            this.gpbDadosUsuarios.TabStop = false;
            this.gpbDadosUsuarios.Text = "Dados do usuário";
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtConfirmaSenha.Location = new System.Drawing.Point(258, 132);
            this.txtConfirmaSenha.MaxLength = 20;
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.PasswordChar = 'l';
            this.txtConfirmaSenha.Size = new System.Drawing.Size(248, 25);
            this.txtConfirmaSenha.TabIndex = 6;
            // 
            // lblConfirmaSenha
            // 
            this.lblConfirmaSenha.AutoSize = true;
            this.lblConfirmaSenha.Location = new System.Drawing.Point(126, 138);
            this.lblConfirmaSenha.Name = "lblConfirmaSenha";
            this.lblConfirmaSenha.Size = new System.Drawing.Size(126, 20);
            this.lblConfirmaSenha.TabIndex = 6;
            this.lblConfirmaSenha.Text = "Confirmar senha";
            // 
            // txtSenhaUsu
            // 
            this.txtSenhaUsu.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtSenhaUsu.Location = new System.Drawing.Point(258, 85);
            this.txtSenhaUsu.MaxLength = 20;
            this.txtSenhaUsu.Name = "txtSenhaUsu";
            this.txtSenhaUsu.PasswordChar = 'l';
            this.txtSenhaUsu.Size = new System.Drawing.Size(248, 25);
            this.txtSenhaUsu.TabIndex = 5;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(196, 91);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(56, 20);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(530, 20);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 40);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(661, 20);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(108, 40);
            this.btnVoltar.TabIndex = 13;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(399, 20);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(108, 40);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(264, 20);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(108, 40);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(136, 20);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(108, 40);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(12, 20);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(108, 40);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pnlOperacoes
            // 
            this.pnlOperacoes.BackColor = System.Drawing.Color.Silver;
            this.pnlOperacoes.Controls.Add(this.btnLimpar);
            this.pnlOperacoes.Controls.Add(this.btnVoltar);
            this.pnlOperacoes.Controls.Add(this.btnPesquisar);
            this.pnlOperacoes.Controls.Add(this.btnExcluir);
            this.pnlOperacoes.Controls.Add(this.btnAlterar);
            this.pnlOperacoes.Controls.Add(this.btnCadastrar);
            this.pnlOperacoes.Location = new System.Drawing.Point(-1, 310);
            this.pnlOperacoes.Name = "pnlOperacoes";
            this.pnlOperacoes.Size = new System.Drawing.Size(789, 74);
            this.pnlOperacoes.TabIndex = 7;
            // 
            // gpbDadosFuncionarios
            // 
            this.gpbDadosFuncionarios.Controls.Add(this.lblNome);
            this.gpbDadosFuncionarios.Controls.Add(this.txtNome);
            this.gpbDadosFuncionarios.Controls.Add(this.lblRegisto);
            this.gpbDadosFuncionarios.Controls.Add(this.cbbCodigo);
            this.gpbDadosFuncionarios.Controls.Add(this.txtRegistro);
            this.gpbDadosFuncionarios.Controls.Add(this.lblCodigo);
            this.gpbDadosFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosFuncionarios.Location = new System.Drawing.Point(12, 11);
            this.gpbDadosFuncionarios.Name = "gpbDadosFuncionarios";
            this.gpbDadosFuncionarios.Size = new System.Drawing.Size(760, 107);
            this.gpbDadosFuncionarios.TabIndex = 0;
            this.gpbDadosFuncionarios.TabStop = false;
            this.gpbDadosFuncionarios.Text = "Dados do funcionário";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(379, 47);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(437, 41);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(303, 26);
            this.txtNome.TabIndex = 3;
            // 
            // lblRegisto
            // 
            this.lblRegisto.AutoSize = true;
            this.lblRegisto.Location = new System.Drawing.Point(182, 47);
            this.lblRegisto.Name = "lblRegisto";
            this.lblRegisto.Size = new System.Drawing.Size(69, 20);
            this.lblRegisto.TabIndex = 11;
            this.lblRegisto.Text = "Registro";
            // 
            // cbbCodigo
            // 
            this.cbbCodigo.FormattingEnabled = true;
            this.cbbCodigo.ItemHeight = 20;
            this.cbbCodigo.Location = new System.Drawing.Point(90, 39);
            this.cbbCodigo.Name = "cbbCodigo";
            this.cbbCodigo.Size = new System.Drawing.Size(82, 28);
            this.cbbCodigo.TabIndex = 1;
            this.cbbCodigo.SelectedIndexChanged += new System.EventHandler(this.cbbCodigo_SelectedIndexChanged_1);
            // 
            // txtRegistro
            // 
            this.txtRegistro.Enabled = false;
            this.txtRegistro.Location = new System.Drawing.Point(255, 41);
            this.txtRegistro.MaxLength = 50;
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(116, 26);
            this.txtRegistro.TabIndex = 2;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(25, 47);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 8;
            this.lblCodigo.Text = "Código";
            // 
            // frmGerenciarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 383);
            this.Controls.Add(this.gpbDadosFuncionarios);
            this.Controls.Add(this.gpbDadosUsuarios);
            this.Controls.Add(this.pnlOperacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGerenciarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Usuários";
            this.Load += new System.EventHandler(this.frmGerenciarUsuarios_Load);
            this.gpbDadosUsuarios.ResumeLayout(false);
            this.gpbDadosUsuarios.PerformLayout();
            this.pnlOperacoes.ResumeLayout(false);
            this.gpbDadosFuncionarios.ResumeLayout(false);
            this.gpbDadosFuncionarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNomeUsu;
        private System.Windows.Forms.Label lblUsuariol;
        private System.Windows.Forms.GroupBox gpbDadosUsuarios;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel pnlOperacoes;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.Label lblConfirmaSenha;
        private System.Windows.Forms.TextBox txtSenhaUsu;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.GroupBox gpbDadosFuncionarios;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblRegisto;
        private System.Windows.Forms.ComboBox cbbCodigo;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.Label lblCodigo;
    }
}