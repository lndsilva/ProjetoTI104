
namespace PortariaApp
{
    partial class frmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rdbBanana = new System.Windows.Forms.RadioButton();
            this.pctBanana = new System.Windows.Forms.PictureBox();
            this.pctMorango = new System.Windows.Forms.PictureBox();
            this.rdbMorango = new System.Windows.Forms.RadioButton();
            this.pctUva = new System.Windows.Forms.PictureBox();
            this.rdbMelancia = new System.Windows.Forms.RadioButton();
            this.pctMelancia = new System.Windows.Forms.PictureBox();
            this.rdbUva = new System.Windows.Forms.RadioButton();
            this.btnEscolha = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblNomeDaFrutra = new System.Windows.Forms.Label();
            this.lblRecebeNome = new System.Windows.Forms.Label();
            this.pctRecebeImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctBanana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMorango)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMelancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRecebeImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(67, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(294, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Escolha uma fruta";
            // 
            // rdbBanana
            // 
            this.rdbBanana.AutoSize = true;
            this.rdbBanana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBanana.Location = new System.Drawing.Point(193, 108);
            this.rdbBanana.Name = "rdbBanana";
            this.rdbBanana.Size = new System.Drawing.Size(83, 24);
            this.rdbBanana.TabIndex = 2;
            this.rdbBanana.Text = "Banana";
            this.rdbBanana.UseVisualStyleBackColor = true;
            this.rdbBanana.CheckedChanged += new System.EventHandler(this.rdbBanana_CheckedChanged);
            // 
            // pctBanana
            // 
            this.pctBanana.Image = ((System.Drawing.Image)(resources.GetObject("pctBanana.Image")));
            this.pctBanana.Location = new System.Drawing.Point(65, 77);
            this.pctBanana.Name = "pctBanana";
            this.pctBanana.Size = new System.Drawing.Size(110, 87);
            this.pctBanana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBanana.TabIndex = 2;
            this.pctBanana.TabStop = false;
            this.pctBanana.Click += new System.EventHandler(this.pctBanana_Click);
            // 
            // pctMorango
            // 
            this.pctMorango.Image = ((System.Drawing.Image)(resources.GetObject("pctMorango.Image")));
            this.pctMorango.Location = new System.Drawing.Point(65, 170);
            this.pctMorango.Name = "pctMorango";
            this.pctMorango.Size = new System.Drawing.Size(110, 87);
            this.pctMorango.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctMorango.TabIndex = 4;
            this.pctMorango.TabStop = false;
            this.pctMorango.Click += new System.EventHandler(this.pctMorango_Click);
            // 
            // rdbMorango
            // 
            this.rdbMorango.AutoSize = true;
            this.rdbMorango.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMorango.Location = new System.Drawing.Point(193, 201);
            this.rdbMorango.Name = "rdbMorango";
            this.rdbMorango.Size = new System.Drawing.Size(90, 24);
            this.rdbMorango.TabIndex = 3;
            this.rdbMorango.Text = "Morango";
            this.rdbMorango.UseVisualStyleBackColor = true;
            this.rdbMorango.CheckedChanged += new System.EventHandler(this.rdbMorango_CheckedChanged);
            // 
            // pctUva
            // 
            this.pctUva.Image = ((System.Drawing.Image)(resources.GetObject("pctUva.Image")));
            this.pctUva.Location = new System.Drawing.Point(65, 355);
            this.pctUva.Name = "pctUva";
            this.pctUva.Size = new System.Drawing.Size(110, 87);
            this.pctUva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctUva.TabIndex = 8;
            this.pctUva.TabStop = false;
            this.pctUva.Click += new System.EventHandler(this.pctUva_Click);
            // 
            // rdbMelancia
            // 
            this.rdbMelancia.AutoSize = true;
            this.rdbMelancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMelancia.Location = new System.Drawing.Point(193, 293);
            this.rdbMelancia.Name = "rdbMelancia";
            this.rdbMelancia.Size = new System.Drawing.Size(90, 24);
            this.rdbMelancia.TabIndex = 4;
            this.rdbMelancia.Text = "Melancia";
            this.rdbMelancia.UseVisualStyleBackColor = true;
            this.rdbMelancia.CheckedChanged += new System.EventHandler(this.rdbMelancia_CheckedChanged);
            // 
            // pctMelancia
            // 
            this.pctMelancia.Image = ((System.Drawing.Image)(resources.GetObject("pctMelancia.Image")));
            this.pctMelancia.Location = new System.Drawing.Point(65, 262);
            this.pctMelancia.Name = "pctMelancia";
            this.pctMelancia.Size = new System.Drawing.Size(110, 87);
            this.pctMelancia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctMelancia.TabIndex = 10;
            this.pctMelancia.TabStop = false;
            this.pctMelancia.Click += new System.EventHandler(this.pctMelancia_Click);
            // 
            // rdbUva
            // 
            this.rdbUva.AutoSize = true;
            this.rdbUva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbUva.Location = new System.Drawing.Point(193, 386);
            this.rdbUva.Name = "rdbUva";
            this.rdbUva.Size = new System.Drawing.Size(55, 24);
            this.rdbUva.TabIndex = 5;
            this.rdbUva.Text = "Uva";
            this.rdbUva.UseVisualStyleBackColor = true;
            this.rdbUva.CheckedChanged += new System.EventHandler(this.rdbUva_CheckedChanged);
            // 
            // btnEscolha
            // 
            this.btnEscolha.Location = new System.Drawing.Point(334, 77);
            this.btnEscolha.Name = "btnEscolha";
            this.btnEscolha.Size = new System.Drawing.Size(110, 87);
            this.btnEscolha.TabIndex = 0;
            this.btnEscolha.Text = "Escolha";
            this.btnEscolha.UseVisualStyleBackColor = true;
            this.btnEscolha.Click += new System.EventHandler(this.btnEscolha_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(334, 171);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(110, 87);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(334, 264);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 87);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblNomeDaFrutra
            // 
            this.lblNomeDaFrutra.AutoSize = true;
            this.lblNomeDaFrutra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDaFrutra.Location = new System.Drawing.Point(65, 476);
            this.lblNomeDaFrutra.Name = "lblNomeDaFrutra";
            this.lblNomeDaFrutra.Size = new System.Drawing.Size(128, 20);
            this.lblNomeDaFrutra.TabIndex = 12;
            this.lblNomeDaFrutra.Text = "Nome da fruta:";
            // 
            // lblRecebeNome
            // 
            this.lblRecebeNome.AutoSize = true;
            this.lblRecebeNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecebeNome.Location = new System.Drawing.Point(189, 476);
            this.lblRecebeNome.Name = "lblRecebeNome";
            this.lblRecebeNome.Size = new System.Drawing.Size(0, 20);
            this.lblRecebeNome.TabIndex = 13;
            // 
            // pctRecebeImagem
            // 
            this.pctRecebeImagem.Location = new System.Drawing.Point(334, 409);
            this.pctRecebeImagem.Name = "pctRecebeImagem";
            this.pctRecebeImagem.Size = new System.Drawing.Size(110, 87);
            this.pctRecebeImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctRecebeImagem.TabIndex = 14;
            this.pctRecebeImagem.TabStop = false;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 532);
            this.Controls.Add(this.pctRecebeImagem);
            this.Controls.Add(this.lblRecebeNome);
            this.Controls.Add(this.lblNomeDaFrutra);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnEscolha);
            this.Controls.Add(this.pctMelancia);
            this.Controls.Add(this.rdbUva);
            this.Controls.Add(this.pctUva);
            this.Controls.Add(this.rdbMelancia);
            this.Controls.Add(this.rdbMorango);
            this.Controls.Add(this.pctMorango);
            this.Controls.Add(this.pctBanana);
            this.Controls.Add(this.rdbBanana);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.pctBanana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMorango)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMelancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRecebeImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rdbBanana;
        private System.Windows.Forms.PictureBox pctBanana;
        private System.Windows.Forms.PictureBox pctMorango;
        private System.Windows.Forms.RadioButton rdbMorango;
        private System.Windows.Forms.PictureBox pctUva;
        private System.Windows.Forms.RadioButton rdbMelancia;
        private System.Windows.Forms.PictureBox pctMelancia;
        private System.Windows.Forms.RadioButton rdbUva;
        private System.Windows.Forms.Button btnEscolha;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblNomeDaFrutra;
        private System.Windows.Forms.Label lblRecebeNome;
        private System.Windows.Forms.PictureBox pctRecebeImagem;
    }
}