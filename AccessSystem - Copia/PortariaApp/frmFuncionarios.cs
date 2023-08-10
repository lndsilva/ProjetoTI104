using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using Correios.Net;

namespace PortariaApp
{
    public partial class frmFuncionarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        //Acessar a variável valor da janela de pesquisa.
        public string nome = "";
        public frmFuncionarios()
        {
            InitializeComponent();

        }

        //criando construtor com parâmetros
        public frmFuncionarios(string nome)
        {
            InitializeComponent();
            this.nome = nome;
            txtNomeFunc.Text = nome;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        public void limparCampos()
        {
            mkbCEP.Clear();
            mkbCPF.Clear();
            mkbCTPS.Clear();
            mkbRF.Clear();
            mkbSerie.Clear();
            mkbTelefone.Clear();
            txtNomeFunc.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            cbbEstado.Text = "";
            rdbFeminino.Checked = false;
            rdbMasculino.Checked = false;
            dtpDataNascimento.Value = DateTime.Now;
            mkbRF.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = "insert into tbFuncionarios(registroFunc,nome,endereco,numero,bairro,cidade,cep," +
                "estado,telefone,cpf,ctps,serie,dataNasc,sexo)" +
                "values(@registroFunc,@nome,@endereco,@numero,@bairro,@cidade," +
                "@cep,@estado,@telefone,@cpf,@ctps,@serie,@dataNasc,@sexo)";
            comm.CommandType = CommandType.Text;
            //limpando os parâmetros de registro
            comm.Parameters.Clear();
            //ligando os campos do SQL ao c#
            comm.Parameters.Add("@registroFunc", MySqlDbType.VarChar, 7).Value = mkbRF.Text;
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNomeFunc.Text;
            comm.Parameters.Add("@endereco", MySqlDbType.VarChar, 100).Value = txtEndereco.Text;
            comm.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = txtNumero.Text;
            comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 50).Value = txtBairro.Text;
            comm.Parameters.Add("@cidade", MySqlDbType.VarChar, 50).Value = txtCidade.Text;
            comm.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = mkbCEP.Text;
            comm.Parameters.Add("@estado", MySqlDbType.VarChar, 50).Value = cbbEstado.Text;
            comm.Parameters.Add("@telefone", MySqlDbType.VarChar, 10).Value = mkbTelefone.Text;
            comm.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = mkbCPF.Text;
            comm.Parameters.Add("@ctps", MySqlDbType.VarChar, 8).Value = mkbCTPS.Text;
            comm.Parameters.Add("@serie", MySqlDbType.VarChar, 4).Value = mkbSerie.Text;
            comm.Parameters.Add("@dataNasc", MySqlDbType.DateTime).Value = dtpDataNascimento.Value;
            if (rdbFeminino.Checked)
            {
                string fem = "F";
                comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 2).Value = fem;
            }
            if (rdbMasculino.Checked)
            {
                string masc = "M";
                comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 2).Value = masc;
            }

            //comm.Connection = Conexao.obterConexao();

            comm.ExecuteNonQuery();

            MessageBox.Show("Cadastrado com sucesso!!!",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            limparCampos();

            Conexao.fecharConexao();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        //criando método para pesquisar o registro do funcionário
        public void pesquisaFuncionario()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbfuncionarios where registroFunc = '" + mkbRF.Text + "';";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

            try
            {
                dr = comm.ExecuteReader();
                dr.Read();

                //mkbRF.Text = dr.GetString(1);
                txtNomeFunc.Text = dr.GetString(2);
                txtEndereco.Text = dr.GetString(3);
                txtNumero.Text = dr.GetString(4);
                txtBairro.Text = dr.GetString(5);
                txtCidade.Text = dr.GetString(6);
                mkbCEP.Text = dr.GetString(7);
                cbbEstado.Text = dr.GetString(8);
                mkbTelefone.Text = dr.GetString(9);
                mkbCPF.Text = dr.GetString(10);
                mkbCTPS.Text = dr.GetString(11);
                mkbSerie.Text = dr.GetString(12);
                dtpDataNascimento.Value = dr.GetDateTime(13);
                if (dr.GetString(14).Equals("F"))
                {
                    rdbFeminino.Checked = true;
                }
                if (dr.GetString(14).Equals("M"))
                {
                    rdbMasculino.Checked = true;
                }
                Conexao.fecharConexao();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Favor inserir o registro do funcionário!!!",
                   "Mensagem do sistema",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);
                limparCampos();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao conectar o banco de dados!!!",
                   "Mensagem do sistema",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);
                limparCampos();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //aqui dentro vamos chamar a janela de pesquisa
            frmPesquisar pesquisar = new frmPesquisar();
            pesquisar.ShowDialog();

        }

        private void btnAdicionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarIMG = new OpenFileDialog();
            BuscarIMG.InitialDirectory = ("d:\\imagens\\");
            BuscarIMG.FileName = "Imagem";
            BuscarIMG.Title = "Procurar Imagem";
            BuscarIMG.Filter = ("*jpg|*.jpg|*png|*.png|*bmp|*.bmp|*tif|*.tif");
            BuscarIMG.ShowDialog();
            pcbFoto.ImageLocation = (BuscarIMG.FileName);

        }

        private void btnExcluirFoto_Click(object sender, EventArgs e)
        {
            pcbFoto.Image = null;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            MySqlCommand comm = new MySqlCommand();
            //Inserindo comandos de SQL para alterar
            comm.CommandText = "update tbFuncionarios set nome = @nome, endereco = @endereco," +
                "numero = @numero, bairro = @bairro,cidade = @cidade, cep = @cep," +
                "estado = @estado,telefone = @telefone,cpf = @cpf," +
                "ctps = @ctps, serie = @serie, dataNasc = @dataNasc,sexo = @sexo where registroFunc = " + mkbRF.Text + ";";

            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNomeFunc.Text;
            comm.Parameters.Add("@endereco", MySqlDbType.VarChar, 100).Value = txtEndereco.Text;
            comm.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = txtNumero.Text;
            comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 50).Value = txtBairro.Text;
            comm.Parameters.Add("@cidade", MySqlDbType.VarChar, 50).Value = txtCidade.Text;
            comm.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = mkbCEP.Text;
            comm.Parameters.Add("@estado", MySqlDbType.VarChar, 50).Value = cbbEstado.Text;
            comm.Parameters.Add("@telefone", MySqlDbType.VarChar, 10).Value = mkbTelefone.Text;
            comm.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = mkbCPF.Text;
            comm.Parameters.Add("@ctps", MySqlDbType.VarChar, 8).Value = mkbCTPS.Text;
            comm.Parameters.Add("@serie", MySqlDbType.VarChar, 4).Value = mkbSerie.Text;
            comm.Parameters.Add("@dataNasc", MySqlDbType.DateTime).Value = dtpDataNascimento.Value;
            if (rdbFeminino.Checked)
            {
                string fem = "F";
                comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 2).Value = fem;
            }
            if (rdbMasculino.Checked)
            {
                string masc = "M";
                comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 2).Value = masc;
            }

            int resp = comm.ExecuteNonQuery();

            if (resp == 1)
            {
                MessageBox.Show("Alterado com sucesso!!!",
                   "Mensagem do sistema",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1);
                limparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao alterar",
                  "Mensagem do sistema",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error,
                  MessageBoxDefaultButton.Button1);
            }


            Conexao.fecharConexao();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult vresp;

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbfuncionarios where registroFunc = @registroFunc";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            comm.Parameters.Clear();
            comm.Parameters.Add("@registroFunc", MySqlDbType.VarChar, 7).Value = mkbRF.Text;

            vresp = MessageBox.Show("Deseja apagar o registro?",
                "Mensagem do sistema", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (vresp == DialogResult.Yes)
            {
                try
                {
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Resistro excluído com sucesso!!!", "Mensagem do sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                catch (Exception)
                {

                    MessageBox.Show("Impossível excluir funcionário, pois é um usuário do sistema!!!", "Mensagem do sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                
            }
            else
            {
                Conexao.fecharConexao();
            }
            Conexao.fecharConexao();



        }

        private void mkbCEP_Leave(object sender, EventArgs e)
        {
            carregaCEP();
        }
        public void carregaCEP()
        {
            if (!string.IsNullOrWhiteSpace(mkbCEP.Text))
            {
                Address endereco = SearchZip.GetAddress(mkbCEP.Text.ToString());
                if (endereco.Zip != null)
                {
                    cbbEstado.Text = endereco.State;
                    txtCidade.Text = endereco.City;
                    txtBairro.Text = endereco.District;
                    txtEndereco.Text = endereco.Street;
                }
                else
                {
                    MessageBox.Show("Cep não localizado...");
                }
            }
            else
            {
                MessageBox.Show("Informe um CEP válido");
            }
        }
    }
}
