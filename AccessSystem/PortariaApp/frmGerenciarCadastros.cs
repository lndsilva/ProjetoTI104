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
    public partial class frmGerenciarCadastros : Form
    {
        public frmGerenciarCadastros()
        {
            InitializeComponent();
        }

        MySqlConnection conn = Conexao.obterConexao();
        public MySqlCommand cmd = new MySqlCommand();


        public DataTable dt = new DataTable();
        public MySqlDataAdapter da = new MySqlDataAdapter();
        public DataSet ds = new DataSet();


        public void ExecutarConsulta(string sql)
        {
            try
            {
                Conexao.obterConexao();
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                throw;
            }

        }
        //Obtem os registros da tabela
        public DataTable GetRegistros(string MySql)
        {
            try
            {
                dt = new DataTable();
                da = new MySqlDataAdapter(MySql, conn);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                throw;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome, email;

            nome = txtNome.Text;
            email = txtEmail.Text;


            dgvDadosCadastrais.Rows.Add(nome, email);
        }
    }
}
