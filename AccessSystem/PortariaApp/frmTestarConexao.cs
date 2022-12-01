using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//importar o driver de conexão
using MySql.Data.MySqlClient;


namespace PortariaApp
{
    public partial class frmTestarConexao : Form
    {
        public frmTestarConexao()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //Instanciando a classe de conexão do mysql
            MySqlConnection conn = new MySqlConnection();
            //criando a string de conexão
            conn.ConnectionString = "Server=localhost;Port=3306;Database=dbPortaria;Uid=root;Pwd=''";
            //abrindo o banco de dados
            try
            {
                conn.Open();
                lblMostrarStatus.Text = "Banco de dados conectado";
            }
            catch (MySqlException)
            {
                lblMostrarStatus.Text = "Erro ao conectar";
            }

        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            //Instanciando a classe de conexão do mysql
            MySqlConnection conn = new MySqlConnection();
            try
            {
                conn.Close();
                lblMostrarStatus.Text = "Banco de dados desconectado";
            }
            catch (MySqlException)
            {
                lblMostrarStatus.Text = "Erro ao conectar";
            }
        }
    }
}
