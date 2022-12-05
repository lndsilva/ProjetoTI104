
namespace PortariaApp
{
    partial class frmLivros
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
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.btnCarregaLivros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLivros
            // 
            this.dgvLivros.AllowUserToAddRows = false;
            this.dgvLivros.AllowUserToDeleteRows = false;
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivros.Location = new System.Drawing.Point(29, 128);
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.ReadOnly = true;
            this.dgvLivros.RowHeadersWidth = 51;
            this.dgvLivros.RowTemplate.Height = 24;
            this.dgvLivros.Size = new System.Drawing.Size(1189, 516);
            this.dgvLivros.TabIndex = 0;
            // 
            // btnCarregaLivros
            // 
            this.btnCarregaLivros.Location = new System.Drawing.Point(29, 55);
            this.btnCarregaLivros.Name = "btnCarregaLivros";
            this.btnCarregaLivros.Size = new System.Drawing.Size(450, 47);
            this.btnCarregaLivros.TabIndex = 1;
            this.btnCarregaLivros.Text = "Carrega";
            this.btnCarregaLivros.UseVisualStyleBackColor = true;
            this.btnCarregaLivros.Click += new System.EventHandler(this.btnCarregaLivros_Click);
            // 
            // frmLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 655);
            this.Controls.Add(this.btnCarregaLivros);
            this.Controls.Add(this.dgvLivros);
            this.Name = "frmLivros";
            this.Text = "frmLivros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLivros;
        private System.Windows.Forms.Button btnCarregaLivros;
    }
}