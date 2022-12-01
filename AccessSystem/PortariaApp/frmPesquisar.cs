using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PortariaApp
{
    public partial class frmPesquisar : Form
    {
        public frmPesquisar()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbNome.Checked == false && rdbRegistroFuncionario.Checked == false)
            {
                MessageBox.Show("Favor selecionar um item!!!",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }

            if (rdbRegistroFuncionario.Checked)
            {
                //criando o método de pesquisa por registro
                pesquisaPorRegistro();

            }
            if (rdbNome.Checked)
            {
                //criando o método de pesquisa por nome
                pesquisaPorNome();
            }
        }

        public void pesquisaPorRegistro()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbfuncionarios where registroFunc = '" + txtDescricao.Text + "';";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                dr.Read();

                lstInformacoes.Items.Clear();

                lstInformacoes.Items.Add(dr.GetString(1));

                Conexao.fecharConexao();
            }
            catch (Exception)
            {
                MessageBox.Show("Conectar banco de dados!!!",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                limparCampos();
            }
        }
        public void pesquisaPorNome()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbFuncionarios where nome like '%" + txtDescricao.Text + "%'";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();

                lstInformacoes.Items.Clear();

                while (dr.Read())
                {
                    lstInformacoes.Items.Add(dr.GetString(1) + " - " + dr.GetString(2));
                }

                Conexao.fecharConexao();
            }
            catch (Exception)
            {
                MessageBox.Show("Conectar banco de dados!!!",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                limparCampos();
            }
        }

        public void limparCampos()
        {
            rdbNome.Checked = false;
            rdbRegistroFuncionario.Checked = false;
            lstInformacoes.Items.Clear();
            txtDescricao.Clear();
            btnPesquisar.Focus();
        }

        //declarando variável global e visível em todo projeto
        public static string valor = "";

        private void lstInformacoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(lstInformacoes.SelectedItem.ToString());
            valor = lstInformacoes.SelectedItem.ToString();
            frmFuncionarios enviar = new frmFuncionarios(valor);
            enviar.Show();
            this.Hide();


        }

        private void frmPesquisar_Load(object sender, EventArgs e)
        {

        }
    }
}
