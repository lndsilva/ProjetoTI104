
namespace PortariaApp
{
    partial class ListagemProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListagemProdutos));
            this.btnListar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtCadastro = new System.Windows.Forms.TextBox();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.cbbProdutos = new System.Windows.Forms.ComboBox();
            this.lblNomeProd = new System.Windows.Forms.Label();
            this.lblProdComb = new System.Windows.Forms.Label();
            this.lblProdList = new System.Windows.Forms.Label();
            this.ltbListaProdutos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(524, 448);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(96, 48);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(647, 448);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(96, 48);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(244, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(318, 33);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Listagem de Produtos";
            // 
            // txtCadastro
            // 
            this.txtCadastro.Location = new System.Drawing.Point(49, 167);
            this.txtCadastro.Name = "txtCadastro";
            this.txtCadastro.Size = new System.Drawing.Size(263, 20);
            this.txtCadastro.TabIndex = 3;
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Location = new System.Drawing.Point(49, 141);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(97, 13);
            this.lblCadastro.TabIndex = 4;
            this.lblCadastro.Text = "Cadastrar Produtos";
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Location = new System.Drawing.Point(49, 270);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(49, 13);
            this.lblProdutos.TabIndex = 5;
            this.lblProdutos.Text = "Produtos";
            // 
            // cbbProdutos
            // 
            this.cbbProdutos.FormattingEnabled = true;
            this.cbbProdutos.Location = new System.Drawing.Point(49, 295);
            this.cbbProdutos.Name = "cbbProdutos";
            this.cbbProdutos.Size = new System.Drawing.Size(263, 21);
            this.cbbProdutos.TabIndex = 6;
            // 
            // lblNomeProd
            // 
            this.lblNomeProd.AutoSize = true;
            this.lblNomeProd.Location = new System.Drawing.Point(521, 141);
            this.lblNomeProd.Name = "lblNomeProd";
            this.lblNomeProd.Size = new System.Drawing.Size(100, 13);
            this.lblNomeProd.TabIndex = 7;
            this.lblNomeProd.Text = "Nome dos Produtos";
            // 
            // lblProdComb
            // 
            this.lblProdComb.AutoSize = true;
            this.lblProdComb.Location = new System.Drawing.Point(49, 384);
            this.lblProdComb.Name = "lblProdComb";
            this.lblProdComb.Size = new System.Drawing.Size(154, 13);
            this.lblProdComb.TabIndex = 8;
            this.lblProdComb.Text = "Produto selecionado na combo";
            // 
            // lblProdList
            // 
            this.lblProdList.AutoSize = true;
            this.lblProdList.Location = new System.Drawing.Point(49, 439);
            this.lblProdList.Name = "lblProdList";
            this.lblProdList.Size = new System.Drawing.Size(140, 13);
            this.lblProdList.TabIndex = 9;
            this.lblProdList.Text = "Produto selecionado na lista";
            // 
            // ltbListaProdutos
            // 
            this.ltbListaProdutos.FormattingEnabled = true;
            this.ltbListaProdutos.Location = new System.Drawing.Point(524, 165);
            this.ltbListaProdutos.Name = "ltbListaProdutos";
            this.ltbListaProdutos.Size = new System.Drawing.Size(219, 264);
            this.ltbListaProdutos.TabIndex = 10;
            // 
            // ListagemProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ltbListaProdutos);
            this.Controls.Add(this.lblProdList);
            this.Controls.Add(this.lblProdComb);
            this.Controls.Add(this.lblNomeProd);
            this.Controls.Add(this.cbbProdutos);
            this.Controls.Add(this.lblProdutos);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.txtCadastro);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnListar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ListagemProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListagemProdutos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtCadastro;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.ComboBox cbbProdutos;
        private System.Windows.Forms.Label lblNomeProd;
        private System.Windows.Forms.Label lblProdComb;
        private System.Windows.Forms.Label lblProdList;
        private System.Windows.Forms.ListBox ltbListaProdutos;
    }
}