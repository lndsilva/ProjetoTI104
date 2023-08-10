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
    public partial class frmCarregaCodigo : Form
    {
        public frmCarregaCodigo()
        {
            InitializeComponent();
            carregaCodigo();
        }

        public void carregaCodigo()
        {
            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = "select codfunc + 1 from tbfuncionarios order by codfunc desc;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

            dr = comm.ExecuteReader();

            dr.Read();

            txtCodigo.Text = Convert.ToString(dr.GetInt32(0));

            Conexao.fecharConexao();

        }

        private void btnCarregaCodigo_Click(object sender, EventArgs e)
        {

        }
    }
}
