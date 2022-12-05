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
    public partial class frmLivros : Form
    {
        public frmLivros()
        {
            InitializeComponent();
        }

        private void btnCarregaLivros_Click(object sender, EventArgs e)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from livros";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao_Livros.obterConexao();

            MySqlDataAdapter da = new MySqlDataAdapter(comm);

            DataTable dt = new DataTable();

            //dt.Load(dt.Load());

            dgvLivros.DataSource = dt;

        }
    }
}
