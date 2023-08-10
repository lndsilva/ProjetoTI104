
namespace PortariaApp
{
    partial class frmFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionarios));
            this.pnlOperacoes = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gpbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.mkbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.mkbCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.mkbRF = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.lblRF = new System.Windows.Forms.Label();
            this.lblCTPS = new System.Windows.Forms.Label();
            this.mkbCTPS = new System.Windows.Forms.MaskedTextBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.mkbSerie = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.mkbCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblSexo = new System.Windows.Forms.Label();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.lblFotoFunc = new System.Windows.Forms.Label();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.btnAdicionarFoto = new System.Windows.Forms.Button();
            this.btnExcluirFoto = new System.Windows.Forms.Button();
            this.gpbDadosFuncionais = new System.Windows.Forms.GroupBox();
            this.pnlOperacoes.SuspendLayout();
            this.gpbDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.gpbDadosFuncionais.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlOperacoes.Location = new System.Drawing.Point(0, 488);
            this.pnlOperacoes.Name = "pnlOperacoes";
            this.pnlOperacoes.Size = new System.Drawing.Size(789, 74);
            this.pnlOperacoes.TabIndex = 19;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(530, 20);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 40);
            this.btnLimpar.TabIndex = 25;
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
            this.btnPesquisar.Location = new System.Drawing.Point(399, 20);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(108, 40);
            this.btnPesquisar.TabIndex = 23;
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
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(136, 20);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(108, 40);
            this.btnAlterar.TabIndex = 21;
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
            this.btnCadastrar.TabIndex = 20;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // gpbDadosPessoais
            // 
            this.gpbDadosPessoais.Controls.Add(this.mkbTelefone);
            this.gpbDadosPessoais.Controls.Add(this.lblTelefone);
            this.gpbDadosPessoais.Controls.Add(this.txtCidade);
            this.gpbDadosPessoais.Controls.Add(this.lblCidade);
            this.gpbDadosPessoais.Controls.Add(this.cbbEstado);
            this.gpbDadosPessoais.Controls.Add(this.lblEstado);
            this.gpbDadosPessoais.Controls.Add(this.mkbCEP);
            this.gpbDadosPessoais.Controls.Add(this.lblCEP);
            this.gpbDadosPessoais.Controls.Add(this.txtBairro);
            this.gpbDadosPessoais.Controls.Add(this.lblBairro);
            this.gpbDadosPessoais.Controls.Add(this.txtNumero);
            this.gpbDadosPessoais.Controls.Add(this.lblNumero);
            this.gpbDadosPessoais.Controls.Add(this.txtEndereco);
            this.gpbDadosPessoais.Controls.Add(this.lblEndereco);
            this.gpbDadosPessoais.Controls.Add(this.mkbRF);
            this.gpbDadosPessoais.Controls.Add(this.txtNomeFunc);
            this.gpbDadosPessoais.Controls.Add(this.lblNomeFunc);
            this.gpbDadosPessoais.Controls.Add(this.lblRF);
            this.gpbDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosPessoais.Location = new System.Drawing.Point(13, 12);
            this.gpbDadosPessoais.Name = "gpbDadosPessoais";
            this.gpbDadosPessoais.Size = new System.Drawing.Size(759, 232);
            this.gpbDadosPessoais.TabIndex = 0;
            this.gpbDadosPessoais.TabStop = false;
            this.gpbDadosPessoais.Text = "Dados pessoais";
            // 
            // mkbTelefone
            // 
            this.mkbTelefone.Location = new System.Drawing.Point(507, 184);
            this.mkbTelefone.Mask = "00000-0000";
            this.mkbTelefone.Name = "mkbTelefone";
            this.mkbTelefone.Size = new System.Drawing.Size(95, 26);
            this.mkbTelefone.TabIndex = 9;
            this.mkbTelefone.ValidatingType = typeof(System.DateTime);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(433, 190);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(71, 20);
            this.lblTelefone.TabIndex = 17;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(421, 134);
            this.txtCidade.MaxLength = 200;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(317, 26);
            this.txtCidade.TabIndex = 6;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(359, 140);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(59, 20);
            this.lblCidade.TabIndex = 15;
            this.lblCidade.Text = "Cidade";
            // 
            // cbbEstado
            // 
            this.cbbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(254, 187);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(154, 23);
            this.cbbEstado.TabIndex = 8;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(191, 190);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Estado";
            // 
            // mkbCEP
            // 
            this.mkbCEP.Location = new System.Drawing.Point(67, 184);
            this.mkbCEP.Mask = "00000-000";
            this.mkbCEP.Name = "mkbCEP";
            this.mkbCEP.Size = new System.Drawing.Size(95, 26);
            this.mkbCEP.TabIndex = 7;
            this.mkbCEP.ValidatingType = typeof(int);
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(23, 190);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(41, 20);
            this.lblCEP.TabIndex = 11;
            this.lblCEP.Text = "CEP";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(77, 134);
            this.txtBairro.MaxLength = 200;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(263, 26);
            this.txtBairro.TabIndex = 5;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(23, 140);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(51, 20);
            this.lblBairro.TabIndex = 9;
            this.lblBairro.Text = "Bairro";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(555, 90);
            this.txtNumero.MaxLength = 200;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(183, 26);
            this.txtNumero.TabIndex = 4;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(486, 96);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(65, 20);
            this.lblNumero.TabIndex = 7;
            this.lblNumero.Text = "Número";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(104, 90);
            this.txtEndereco.MaxLength = 200;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(365, 26);
            this.txtEndereco.TabIndex = 3;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(22, 96);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(78, 20);
            this.lblEndereco.TabIndex = 5;
            this.lblEndereco.Text = "Endereço";
            // 
            // mkbRF
            // 
            this.mkbRF.Location = new System.Drawing.Point(57, 39);
            this.mkbRF.Mask = "00000-0";
            this.mkbRF.Name = "mkbRF";
            this.mkbRF.Size = new System.Drawing.Size(74, 26);
            this.mkbRF.TabIndex = 1;
            this.mkbRF.ValidatingType = typeof(System.DateTime);
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(204, 39);
            this.txtNomeFunc.MaxLength = 200;
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(534, 26);
            this.txtNomeFunc.TabIndex = 2;
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Location = new System.Drawing.Point(149, 45);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(51, 20);
            this.lblNomeFunc.TabIndex = 2;
            this.lblNomeFunc.Text = "Nome";
            // 
            // lblRF
            // 
            this.lblRF.AutoSize = true;
            this.lblRF.Location = new System.Drawing.Point(22, 45);
            this.lblRF.Name = "lblRF";
            this.lblRF.Size = new System.Drawing.Size(31, 20);
            this.lblRF.TabIndex = 0;
            this.lblRF.Text = "RF";
            // 
            // lblCTPS
            // 
            this.lblCTPS.AutoSize = true;
            this.lblCTPS.Location = new System.Drawing.Point(28, 95);
            this.lblCTPS.Name = "lblCTPS";
            this.lblCTPS.Size = new System.Drawing.Size(50, 20);
            this.lblCTPS.TabIndex = 0;
            this.lblCTPS.Text = "CTPS";
            // 
            // mkbCTPS
            // 
            this.mkbCTPS.Location = new System.Drawing.Point(82, 89);
            this.mkbCTPS.Mask = "00000000";
            this.mkbCTPS.Name = "mkbCTPS";
            this.mkbCTPS.Size = new System.Drawing.Size(85, 26);
            this.mkbCTPS.TabIndex = 12;
            this.mkbCTPS.ValidatingType = typeof(System.DateTime);
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(193, 95);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(46, 20);
            this.lblSerie.TabIndex = 2;
            this.lblSerie.Text = "Série";
            // 
            // mkbSerie
            // 
            this.mkbSerie.Location = new System.Drawing.Point(243, 89);
            this.mkbSerie.Mask = "0000";
            this.mkbSerie.Name = "mkbSerie";
            this.mkbSerie.Size = new System.Drawing.Size(55, 26);
            this.mkbSerie.TabIndex = 13;
            this.mkbSerie.ValidatingType = typeof(System.DateTime);
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
            // mkbCPF
            // 
            this.mkbCPF.Location = new System.Drawing.Point(68, 35);
            this.mkbCPF.Mask = "000,000,000-00";
            this.mkbCPF.Name = "mkbCPF";
            this.mkbCPF.Size = new System.Drawing.Size(122, 26);
            this.mkbCPF.TabIndex = 11;
            this.mkbCPF.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(32, 151);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(130, 20);
            this.lblDataNasc.TabIndex = 14;
            this.lblDataNasc.Text = "Data nascimento";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(177, 145);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(103, 26);
            this.dtpDataNascimento.TabIndex = 14;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(316, 35);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(45, 20);
            this.lblSexo.TabIndex = 16;
            this.lblSexo.Text = "Sexo";
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(371, 37);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(92, 24);
            this.rdbFeminino.TabIndex = 15;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(371, 72);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(98, 24);
            this.rdbMasculino.TabIndex = 16;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // lblFotoFunc
            // 
            this.lblFotoFunc.AutoSize = true;
            this.lblFotoFunc.Location = new System.Drawing.Point(487, 37);
            this.lblFotoFunc.Name = "lblFotoFunc";
            this.lblFotoFunc.Size = new System.Drawing.Size(42, 20);
            this.lblFotoFunc.TabIndex = 19;
            this.lblFotoFunc.Text = "Foto";
            // 
            // pcbFoto
            // 
            this.pcbFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pcbFoto.Location = new System.Drawing.Point(535, 41);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(173, 152);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoto.TabIndex = 20;
            this.pcbFoto.TabStop = false;
            // 
            // btnAdicionarFoto
            // 
            this.btnAdicionarFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarFoto.Image")));
            this.btnAdicionarFoto.Location = new System.Drawing.Point(714, 41);
            this.btnAdicionarFoto.Name = "btnAdicionarFoto";
            this.btnAdicionarFoto.Size = new System.Drawing.Size(35, 33);
            this.btnAdicionarFoto.TabIndex = 17;
            this.btnAdicionarFoto.Tag = "Adicionar foto funcionário";
            this.btnAdicionarFoto.UseVisualStyleBackColor = true;
            this.btnAdicionarFoto.Click += new System.EventHandler(this.btnAdicionarFoto_Click);
            // 
            // btnExcluirFoto
            // 
            this.btnExcluirFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirFoto.Image")));
            this.btnExcluirFoto.Location = new System.Drawing.Point(714, 80);
            this.btnExcluirFoto.Name = "btnExcluirFoto";
            this.btnExcluirFoto.Size = new System.Drawing.Size(35, 33);
            this.btnExcluirFoto.TabIndex = 18;
            this.btnExcluirFoto.Tag = "Excluir foto funcionário";
            this.btnExcluirFoto.UseVisualStyleBackColor = true;
            this.btnExcluirFoto.Click += new System.EventHandler(this.btnExcluirFoto_Click);
            // 
            // gpbDadosFuncionais
            // 
            this.gpbDadosFuncionais.Controls.Add(this.btnExcluirFoto);
            this.gpbDadosFuncionais.Controls.Add(this.btnAdicionarFoto);
            this.gpbDadosFuncionais.Controls.Add(this.pcbFoto);
            this.gpbDadosFuncionais.Controls.Add(this.lblFotoFunc);
            this.gpbDadosFuncionais.Controls.Add(this.rdbMasculino);
            this.gpbDadosFuncionais.Controls.Add(this.rdbFeminino);
            this.gpbDadosFuncionais.Controls.Add(this.lblSexo);
            this.gpbDadosFuncionais.Controls.Add(this.dtpDataNascimento);
            this.gpbDadosFuncionais.Controls.Add(this.lblDataNasc);
            this.gpbDadosFuncionais.Controls.Add(this.mkbCPF);
            this.gpbDadosFuncionais.Controls.Add(this.lblCPF);
            this.gpbDadosFuncionais.Controls.Add(this.mkbSerie);
            this.gpbDadosFuncionais.Controls.Add(this.lblSerie);
            this.gpbDadosFuncionais.Controls.Add(this.mkbCTPS);
            this.gpbDadosFuncionais.Controls.Add(this.lblCTPS);
            this.gpbDadosFuncionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosFuncionais.Location = new System.Drawing.Point(13, 250);
            this.gpbDadosFuncionais.Name = "gpbDadosFuncionais";
            this.gpbDadosFuncionais.Size = new System.Drawing.Size(759, 216);
            this.gpbDadosFuncionais.TabIndex = 10;
            this.gpbDadosFuncionais.TabStop = false;
            this.gpbDadosFuncionais.Text = "Dados funcionais";
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gpbDadosFuncionais);
            this.Controls.Add(this.gpbDadosPessoais);
            this.Controls.Add(this.pnlOperacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portaria - Funcionários";
            this.Load += new System.EventHandler(this.frmFuncionarios_Load);
            this.pnlOperacoes.ResumeLayout(false);
            this.gpbDadosPessoais.ResumeLayout(false);
            this.gpbDadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.gpbDadosFuncionais.ResumeLayout(false);
            this.gpbDadosFuncionais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOperacoes;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox gpbDadosPessoais;
        private System.Windows.Forms.Label lblRF;
        private System.Windows.Forms.MaskedTextBox mkbRF;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.MaskedTextBox mkbCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.MaskedTextBox mkbTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblCTPS;
        private System.Windows.Forms.MaskedTextBox mkbCTPS;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.MaskedTextBox mkbSerie;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox mkbCPF;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.Label lblFotoFunc;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.Button btnAdicionarFoto;
        private System.Windows.Forms.Button btnExcluirFoto;
        private System.Windows.Forms.GroupBox gpbDadosFuncionais;
    }
}