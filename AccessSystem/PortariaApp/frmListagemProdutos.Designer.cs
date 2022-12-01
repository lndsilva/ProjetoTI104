
namespace PortariaApp
{
    partial class frmListagemProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListagemProdutos));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCombProd = new System.Windows.Forms.Label();
            this.cbbProdutos = new System.Windows.Forms.ComboBox();
            this.ltbListaProdutos = new System.Windows.Forms.ListBox();
            this.lblListaProdutos = new System.Windows.Forms.Label();
            this.lblCadProd = new System.Windows.Forms.Label();
            this.txtCadProd = new System.Windows.Forms.TextBox();
            this.lblProdSelCombo = new System.Windows.Forms.Label();
            this.lblProdSelList = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtProdSelCombo = new System.Windows.Forms.TextBox();
            this.txtProdSelList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(235, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(294, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Listagem de produtos";
            // 
            // lblCombProd
            // 
            this.lblCombProd.AutoSize = true;
            this.lblCombProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombProd.Location = new System.Drawing.Point(62, 194);
            this.lblCombProd.Name = "lblCombProd";
            this.lblCombProd.Size = new System.Drawing.Size(62, 16);
            this.lblCombProd.TabIndex = 1;
            this.lblCombProd.Text = "Produtos";
            // 
            // cbbProdutos
            // 
            this.cbbProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbProdutos.FormattingEnabled = true;
            this.cbbProdutos.Location = new System.Drawing.Point(62, 220);
            this.cbbProdutos.Name = "cbbProdutos";
            this.cbbProdutos.Size = new System.Drawing.Size(227, 24);
            this.cbbProdutos.TabIndex = 1;
            this.cbbProdutos.SelectedIndexChanged += new System.EventHandler(this.cbbProdutos_SelectedIndexChanged);
            // 
            // ltbListaProdutos
            // 
            this.ltbListaProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbListaProdutos.FormattingEnabled = true;
            this.ltbListaProdutos.ItemHeight = 16;
            this.ltbListaProdutos.Location = new System.Drawing.Point(424, 115);
            this.ltbListaProdutos.Name = "ltbListaProdutos";
            this.ltbListaProdutos.Size = new System.Drawing.Size(255, 228);
            this.ltbListaProdutos.TabIndex = 2;
            this.ltbListaProdutos.SelectedIndexChanged += new System.EventHandler(this.ltbListaProdutos_SelectedIndexChanged);
            // 
            // lblListaProdutos
            // 
            this.lblListaProdutos.AutoSize = true;
            this.lblListaProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaProdutos.Location = new System.Drawing.Point(424, 93);
            this.lblListaProdutos.Name = "lblListaProdutos";
            this.lblListaProdutos.Size = new System.Drawing.Size(111, 16);
            this.lblListaProdutos.TabIndex = 4;
            this.lblListaProdutos.Text = "Lista de produtos";
            // 
            // lblCadProd
            // 
            this.lblCadProd.AutoSize = true;
            this.lblCadProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadProd.Location = new System.Drawing.Point(62, 93);
            this.lblCadProd.Name = "lblCadProd";
            this.lblCadProd.Size = new System.Drawing.Size(123, 16);
            this.lblCadProd.TabIndex = 5;
            this.lblCadProd.Text = "Cadastrar produtos";
            // 
            // txtCadProd
            // 
            this.txtCadProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadProd.Location = new System.Drawing.Point(62, 115);
            this.txtCadProd.MaxLength = 100;
            this.txtCadProd.Name = "txtCadProd";
            this.txtCadProd.Size = new System.Drawing.Size(227, 22);
            this.txtCadProd.TabIndex = 0;
            this.txtCadProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCadProd_KeyDown);
            // 
            // lblProdSelCombo
            // 
            this.lblProdSelCombo.AutoSize = true;
            this.lblProdSelCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdSelCombo.Location = new System.Drawing.Point(62, 295);
            this.lblProdSelCombo.Name = "lblProdSelCombo";
            this.lblProdSelCombo.Size = new System.Drawing.Size(203, 16);
            this.lblProdSelCombo.TabIndex = 7;
            this.lblProdSelCombo.Text = "Produtos selecionado na combo";
            // 
            // lblProdSelList
            // 
            this.lblProdSelList.AutoSize = true;
            this.lblProdSelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdSelList.Location = new System.Drawing.Point(62, 360);
            this.lblProdSelList.Name = "lblProdSelList";
            this.lblProdSelList.Size = new System.Drawing.Size(185, 16);
            this.lblProdSelList.TabIndex = 8;
            this.lblProdSelList.Text = "Produtos selecionado na lista";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(424, 380);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(125, 51);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(554, 380);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(125, 51);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtProdSelCombo
            // 
            this.txtProdSelCombo.Enabled = false;
            this.txtProdSelCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdSelCombo.Location = new System.Drawing.Point(62, 317);
            this.txtProdSelCombo.Name = "txtProdSelCombo";
            this.txtProdSelCombo.Size = new System.Drawing.Size(224, 22);
            this.txtProdSelCombo.TabIndex = 9;
            // 
            // txtProdSelList
            // 
            this.txtProdSelList.Enabled = false;
            this.txtProdSelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdSelList.Location = new System.Drawing.Point(62, 382);
            this.txtProdSelList.Name = "txtProdSelList";
            this.txtProdSelList.Size = new System.Drawing.Size(224, 22);
            this.txtProdSelList.TabIndex = 10;
            // 
            // frmListagemProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 453);
            this.Controls.Add(this.txtProdSelList);
            this.Controls.Add(this.txtProdSelCombo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblProdSelList);
            this.Controls.Add(this.lblProdSelCombo);
            this.Controls.Add(this.txtCadProd);
            this.Controls.Add(this.lblCadProd);
            this.Controls.Add(this.lblListaProdutos);
            this.Controls.Add(this.ltbListaProdutos);
            this.Controls.Add(this.cbbProdutos);
            this.Controls.Add(this.lblCombProd);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmListagemProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCombProd;
        private System.Windows.Forms.ComboBox cbbProdutos;
        private System.Windows.Forms.ListBox ltbListaProdutos;
        private System.Windows.Forms.Label lblListaProdutos;
        private System.Windows.Forms.Label lblCadProd;
        private System.Windows.Forms.TextBox txtCadProd;
        private System.Windows.Forms.Label lblProdSelCombo;
        private System.Windows.Forms.Label lblProdSelList;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtProdSelCombo;
        private System.Windows.Forms.TextBox txtProdSelList;
    }
}