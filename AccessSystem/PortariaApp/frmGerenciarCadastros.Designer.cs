
namespace PortariaApp
{
    partial class frmGerenciarCadastros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarCadastros));
            this.lblNome = new System.Windows.Forms.Label();
            this.lnlEmail = new System.Windows.Forms.Label();
            this.lblProdurar = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.gbpDadosCadastrais = new System.Windows.Forms.GroupBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dgvDadosCadastrais = new System.Windows.Forms.DataGridView();
            this.dgvNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbpDadosCadastrais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosCadastrais)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(16, 47);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lnlEmail
            // 
            this.lnlEmail.AutoSize = true;
            this.lnlEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlEmail.Location = new System.Drawing.Point(15, 107);
            this.lnlEmail.Name = "lnlEmail";
            this.lnlEmail.Size = new System.Drawing.Size(46, 16);
            this.lnlEmail.TabIndex = 1;
            this.lnlEmail.Text = "E-mail";
            // 
            // lblProdurar
            // 
            this.lblProdurar.AutoSize = true;
            this.lblProdurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdurar.Location = new System.Drawing.Point(392, 107);
            this.lblProdurar.Name = "lblProdurar";
            this.lblProdurar.Size = new System.Drawing.Size(59, 16);
            this.lblProdurar.TabIndex = 2;
            this.lblProdurar.Text = "Procurar";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(68, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(273, 22);
            this.txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(68, 104);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(270, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // txtProcurar
            // 
            this.txtProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcurar.Location = new System.Drawing.Point(457, 104);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(185, 22);
            this.txtProcurar.TabIndex = 3;
            // 
            // gbpDadosCadastrais
            // 
            this.gbpDadosCadastrais.Controls.Add(this.btnDeletar);
            this.gbpDadosCadastrais.Controls.Add(this.btnEditar);
            this.gbpDadosCadastrais.Controls.Add(this.btnAdicionar);
            this.gbpDadosCadastrais.Controls.Add(this.txtProcurar);
            this.gbpDadosCadastrais.Controls.Add(this.lblNome);
            this.gbpDadosCadastrais.Controls.Add(this.txtEmail);
            this.gbpDadosCadastrais.Controls.Add(this.lnlEmail);
            this.gbpDadosCadastrais.Controls.Add(this.txtNome);
            this.gbpDadosCadastrais.Controls.Add(this.lblProdurar);
            this.gbpDadosCadastrais.Location = new System.Drawing.Point(12, 12);
            this.gbpDadosCadastrais.Name = "gbpDadosCadastrais";
            this.gbpDadosCadastrais.Size = new System.Drawing.Size(665, 155);
            this.gbpDadosCadastrais.TabIndex = 0;
            this.gbpDadosCadastrais.TabStop = false;
            this.gbpDadosCadastrais.Text = "Dados Cadastrais";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(562, 44);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(80, 23);
            this.btnDeletar.TabIndex = 6;
            this.btnDeletar.Text = "&Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(471, 44);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(80, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(378, 44);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(80, 23);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "&Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dgvDadosCadastrais
            // 
            this.dgvDadosCadastrais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosCadastrais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNome,
            this.dgvEmail});
            this.dgvDadosCadastrais.Location = new System.Drawing.Point(14, 184);
            this.dgvDadosCadastrais.Name = "dgvDadosCadastrais";
            this.dgvDadosCadastrais.Size = new System.Drawing.Size(662, 326);
            this.dgvDadosCadastrais.TabIndex = 7;
            this.dgvDadosCadastrais.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDadosCadastrais_CellContentClick);
            // 
            // dgvNome
            // 
            this.dgvNome.HeaderText = "Nome";
            this.dgvNome.MaxInputLength = 100;
            this.dgvNome.Name = "dgvNome";
            this.dgvNome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNome.Width = 150;
            // 
            // dgvEmail
            // 
            this.dgvEmail.HeaderText = "E-mail";
            this.dgvEmail.MaxInputLength = 100;
            this.dgvEmail.Name = "dgvEmail";
            this.dgvEmail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmail.Width = 150;
            // 
            // frmGerenciarCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 520);
            this.Controls.Add(this.dgvDadosCadastrais);
            this.Controls.Add(this.gbpDadosCadastrais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGerenciarCadastros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Cadastros";
            this.gbpDadosCadastrais.ResumeLayout(false);
            this.gbpDadosCadastrais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosCadastrais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lnlEmail;
        private System.Windows.Forms.Label lblProdurar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.GroupBox gbpDadosCadastrais;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dgvDadosCadastrais;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmail;
    }
}