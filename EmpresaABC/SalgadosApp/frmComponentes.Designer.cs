
namespace SalgadosApp
{
    partial class frmComponentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComponentes));
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.gpbPreferencias = new System.Windows.Forms.GroupBox();
            this.ckbLivros = new System.Windows.Forms.CheckBox();
            this.ckbAcademia = new System.Windows.Forms.CheckBox();
            this.ckbCelular = new System.Windows.Forms.CheckBox();
            this.ckbComida = new System.Windows.Forms.CheckBox();
            this.ckbBebida = new System.Windows.Forms.CheckBox();
            this.ckbCorrer = new System.Windows.Forms.CheckBox();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblListaEscolar = new System.Windows.Forms.Label();
            this.ltbListaEscolar = new System.Windows.Forms.ListBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.gpbSexo.SuspendLayout();
            this.gpbPreferencias.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rdbFeminino);
            this.gpbSexo.Controls.Add(this.rdbMasculino);
            this.gpbSexo.Location = new System.Drawing.Point(71, 61);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(162, 121);
            this.gpbSexo.TabIndex = 0;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.Location = new System.Drawing.Point(43, 37);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(104, 24);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(43, 76);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdbFeminino.TabIndex = 1;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // gpbPreferencias
            // 
            this.gpbPreferencias.Controls.Add(this.ckbCorrer);
            this.gpbPreferencias.Controls.Add(this.ckbBebida);
            this.gpbPreferencias.Controls.Add(this.ckbComida);
            this.gpbPreferencias.Controls.Add(this.ckbCelular);
            this.gpbPreferencias.Controls.Add(this.ckbAcademia);
            this.gpbPreferencias.Controls.Add(this.ckbLivros);
            this.gpbPreferencias.Location = new System.Drawing.Point(71, 216);
            this.gpbPreferencias.Name = "gpbPreferencias";
            this.gpbPreferencias.Size = new System.Drawing.Size(157, 208);
            this.gpbPreferencias.TabIndex = 1;
            this.gpbPreferencias.TabStop = false;
            this.gpbPreferencias.Text = "Preferências";
            // 
            // ckbLivros
            // 
            this.ckbLivros.AutoSize = true;
            this.ckbLivros.Location = new System.Drawing.Point(27, 40);
            this.ckbLivros.Name = "ckbLivros";
            this.ckbLivros.Size = new System.Drawing.Size(54, 17);
            this.ckbLivros.TabIndex = 0;
            this.ckbLivros.Text = "Livros";
            this.ckbLivros.UseVisualStyleBackColor = true;
            // 
            // ckbAcademia
            // 
            this.ckbAcademia.AutoSize = true;
            this.ckbAcademia.Location = new System.Drawing.Point(27, 64);
            this.ckbAcademia.Name = "ckbAcademia";
            this.ckbAcademia.Size = new System.Drawing.Size(73, 17);
            this.ckbAcademia.TabIndex = 1;
            this.ckbAcademia.Text = "Academia";
            this.ckbAcademia.UseVisualStyleBackColor = true;
            // 
            // ckbCelular
            // 
            this.ckbCelular.AutoSize = true;
            this.ckbCelular.Location = new System.Drawing.Point(27, 88);
            this.ckbCelular.Name = "ckbCelular";
            this.ckbCelular.Size = new System.Drawing.Size(58, 17);
            this.ckbCelular.TabIndex = 2;
            this.ckbCelular.Text = "Celular";
            this.ckbCelular.UseVisualStyleBackColor = true;
            this.ckbCelular.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // ckbComida
            // 
            this.ckbComida.AutoSize = true;
            this.ckbComida.Location = new System.Drawing.Point(27, 112);
            this.ckbComida.Name = "ckbComida";
            this.ckbComida.Size = new System.Drawing.Size(61, 17);
            this.ckbComida.TabIndex = 3;
            this.ckbComida.Text = "Comida";
            this.ckbComida.UseVisualStyleBackColor = true;
            // 
            // ckbBebida
            // 
            this.ckbBebida.AutoSize = true;
            this.ckbBebida.Location = new System.Drawing.Point(27, 135);
            this.ckbBebida.Name = "ckbBebida";
            this.ckbBebida.Size = new System.Drawing.Size(59, 17);
            this.ckbBebida.TabIndex = 4;
            this.ckbBebida.Text = "Bebida";
            this.ckbBebida.UseVisualStyleBackColor = true;
            // 
            // ckbCorrer
            // 
            this.ckbCorrer.AutoSize = true;
            this.ckbCorrer.Location = new System.Drawing.Point(27, 158);
            this.ckbCorrer.Name = "ckbCorrer";
            this.ckbCorrer.Size = new System.Drawing.Size(54, 17);
            this.ckbCorrer.TabIndex = 5;
            this.ckbCorrer.Text = "Correr";
            this.ckbCorrer.UseVisualStyleBackColor = true;
            // 
            // cbbEstado
            // 
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Items.AddRange(new object[] {
            "São Paulo",
            "Belo Horizonte",
            "Paraná",
            "Ceará",
            "Rio de Janeiro",
            "Acre",
            "Bahia"});
            this.cbbEstado.Location = new System.Drawing.Point(298, 85);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(137, 21);
            this.cbbEstado.TabIndex = 2;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(298, 61);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "Estado";
            // 
            // lblListaEscolar
            // 
            this.lblListaEscolar.AutoSize = true;
            this.lblListaEscolar.Location = new System.Drawing.Point(577, 61);
            this.lblListaEscolar.Name = "lblListaEscolar";
            this.lblListaEscolar.Size = new System.Drawing.Size(67, 13);
            this.lblListaEscolar.TabIndex = 4;
            this.lblListaEscolar.Text = "Lista Escolar";
            // 
            // ltbListaEscolar
            // 
            this.ltbListaEscolar.FormattingEnabled = true;
            this.ltbListaEscolar.Items.AddRange(new object[] {
            "Borracha",
            "Caderno",
            "Caneta",
            "Cola",
            "Lápis",
            "Tesoura",
            "Régua",
            "Canetinha"});
            this.ltbListaEscolar.Location = new System.Drawing.Point(578, 89);
            this.ltbListaEscolar.Name = "ltbListaEscolar";
            this.ltbListaEscolar.Size = new System.Drawing.Size(186, 238);
            this.ltbListaEscolar.TabIndex = 5;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(298, 159);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(237, 20);
            this.dtpData.TabIndex = 6;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(298, 137);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 7;
            this.lblData.Text = "Data";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(298, 209);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 8;
            this.lblHora.Text = "Hora";
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(298, 231);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(68, 20);
            this.dtpHora.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(3, 557);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 63);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(307, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(445, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 34);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(583, 17);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 34);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(721, 17);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 34);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // frmComponentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 620);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.ltbListaEscolar);
            this.Controls.Add(this.lblListaEscolar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cbbEstado);
            this.Controls.Add(this.gpbPreferencias);
            this.Controls.Add(this.gpbSexo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmComponentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes";
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.gpbPreferencias.ResumeLayout(false);
            this.gpbPreferencias.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.GroupBox gpbPreferencias;
        private System.Windows.Forms.CheckBox ckbComida;
        private System.Windows.Forms.CheckBox ckbCelular;
        private System.Windows.Forms.CheckBox ckbAcademia;
        private System.Windows.Forms.CheckBox ckbLivros;
        private System.Windows.Forms.CheckBox ckbCorrer;
        private System.Windows.Forms.CheckBox ckbBebida;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblListaEscolar;
        private System.Windows.Forms.ListBox ltbListaEscolar;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}